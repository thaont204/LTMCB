﻿using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Threading.Tasks;
using System.Linq;

namespace MailApp
{
    public partial class frm_MailBox : Form
    {
        MailRepository mailRepository;
        List<MimeMessage> messageList;
        Form frmCompose;

        Dictionary<SearchQuery, string> cbItems;
        int mailIndex;

        private async Task RenderMails(SearchQuery searchQuery, string CacheKey)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            messageList = await mailRepository.LoadMails(searchQuery, CacheKey);
            lbl_Count.Text = messageList.Count.ToString();
            lbl_Selected.Text = dataGridView.SelectedRows.Count.ToString(); 

            foreach (MimeMessage message in messageList)
            {
                int index = dataGridView.Rows.Add();
                DataGridViewRow emailItem = dataGridView.Rows[index];
                MessageBox.Show(message.From.ToString());
                emailItem.Cells["Sender"].Value = message.From.ToString();
                emailItem.Cells["Sender"].ToolTipText = message.From.ToString();
                emailItem.Cells["Subject"].Value = message.Subject;
                emailItem.Cells["Date"].Value = message.Date.ToString("dd/MM/yy");
            }
        }

        private void OpenCompose(MailRepository mailRepository, string to = "", string cc = "", string bcc = "")
        {
            frmCompose = Application.OpenForms["frm_Compose"];
            if (frmCompose != null)
                frmCompose.BringToFront();
            else
            {
                frmCompose = new frm_Compose(mailRepository, to, cc, bcc);
                frmCompose.TopMost = true;
                frmCompose.Show();
            }
        }
        public frm_MailBox(MailRepository mailRepository)
        {
            InitializeComponent();
            this.mailRepository = mailRepository;

            cbItems = new Dictionary<SearchQuery, string>()
            {
                {SearchQuery.All, "Hộp thư đến" },
                {SearchQuery.Seen, "Đã xem"},
                {SearchQuery.NotSeen, "Chưa xem"},
                {SearchQuery.Answered, "Đã trả lời"},
                {SearchQuery.SentBefore(DateTime.Today), "Chưa trả lời"}
            };

            cb_MailType.DataSource = new BindingSource(cbItems, null);
            cb_MailType.DisplayMember = "Value";
            cb_MailType.ValueMember = "Key";
        }

        private async void cb_MailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchQuery searchQuery = ((KeyValuePair<SearchQuery, string>)cb_MailType.SelectedItem).Key;
            await RenderMails(searchQuery, searchQuery.Term.ToString());
        }
        
        private async void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Search.Text)) return;
            TextSearchQuery searchQuery = SearchQuery.BodyContains(txt_Search.Text);
            await RenderMails(searchQuery, searchQuery.Text);
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            Form frmCompose = Application.OpenForms["frm_Compose"];
            if (frmCompose != null) frmCompose.Close();

            mailRepository.Disconnect();
            frm_SignIn frmSignIn = new frm_SignIn();
            Hide();

            frmSignIn.ShowDialog();
            Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pn_MailControls.SendToBack();
            pn_Mail.SendToBack();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Compose_Click(object sender, EventArgs e)
        {
            OpenCompose(mailRepository);
        }

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            string to = messageList[mailIndex].From.ToString().Split('"')[2];
            string cc = messageList[mailIndex].Cc.ToString();
            string bcc = messageList[mailIndex].Bcc.ToString();
            OpenCompose(mailRepository, to, cc, bcc);
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            string cc = messageList[mailIndex].Cc.ToString();
            string bcc = messageList[mailIndex].Bcc.ToString();
            OpenCompose(mailRepository, "", cc, bcc);
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < 0)
                lbl_Selected.Text = dataGridView.SelectedRows.Count.ToString();

            if (e.Button == MouseButtons.Right)
            {
                dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[1];
                contextMenuStrip.Show(dataGridView, e.Location);
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pn_MailControls.BringToFront();
            pn_Mail.BringToFront();

            mailIndex = dataGridView.CurrentCell.RowIndex;
            lbl_MailIndex.Text = string.Concat(
                mailIndex + 1, " trong tổng số ", messageList.Count, " thư"
            );
            webBrowser.DocumentText = messageList[mailIndex].HtmlBody;
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_Search_Click(this, new EventArgs());
        }

        private void chb_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_SelectAll.Checked) dataGridView.SelectAll();
            else dataGridView.ClearSelection();
        }

        private void frm_MailBox_Load(object sender, EventArgs e)
        {
        }

        private async void mailbox_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    await client.ConnectAsync("imap.gmail.com", 993, true);

                    // Đăng nhập
                    await client.AuthenticateAsync(mailRepository.email, "pmehdmrxslzduqsh");

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    // Lấy tất cả các ID email và sắp xếp chúng theo thứ tự giảm dần
                    var uids = await inbox.SearchAsync(SearchQuery.All);
                    var sortedUids = uids.OrderByDescending(uid => uid.Id).Take(15).ToList();

                    // Lấy email theo danh sách ID đã sắp xếp
                    lvData.Items.Clear();  // Clear the ListView before adding new items
                    foreach (var uid in sortedUids)
                    {
                        var message = await inbox.GetMessageAsync(uid);
                        ListViewItem item = new ListViewItem(message.From.ToString());
                        item.SubItems.Add(message.Subject.ToString());
                        item.SubItems.Add(message.Date.ToString());
                        lvData.Items.Add(item);
                    }

                    // Đóng kết nối
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}