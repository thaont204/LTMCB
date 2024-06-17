using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MailApp
{
    public partial class frm_Compose : Form
    {
        MailRepository mailRepository;
        List<string> listFiles = new List<string>();
        bool haveattach =false;
        public frm_Compose(MailRepository mailRepository, string to = "", string cc = "", string bcc = "", string messages = "")
        {
            InitializeComponent();
            this.mailRepository = mailRepository;
            txt_To.Text = to;
            txt_CC.Text = cc;
            txt_BCC.Text = bcc;
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
            ofd.Multiselect = true;
            haveattach = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            foreach (string file in ofd.FileNames) listFiles.Add(file);
            txt_Files.Text = string.Join(", ", listFiles.ToArray());
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string smtpServer = txt_SMTP.Text;
            int port = Convert.ToInt32(txt_Port.Text);
            try
            {
                mailRepository.ConnectStmpServer(smtpServer, port, chb_SSL.Checked);

                if (haveattach)
                {
                    mailRepository.SendMail(listFiles, txt_Subject.Text, txt_Message.Text, txt_To.Text);
                }
                else
                {
                    mailRepository.SendMail(txt_Subject.Text, txt_Message.Text, txt_To.Text);
                }
                MessageBox.Show("Sent successfully!!!");
                this.Hide();
                frm_MailBox frm_MailBox = new frm_MailBox(mailRepository);
                frm_MailBox.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
