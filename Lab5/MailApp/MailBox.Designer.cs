namespace MailApp
{
    partial class frm_MailBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_Compose = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_MailType = new System.Windows.Forms.ComboBox();
            this.chb_SelectAll = new System.Windows.Forms.CheckBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Selected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_MailControls = new System.Windows.Forms.Panel();
            this.lbl_MailIndex = new System.Windows.Forms.Label();
            this.btn_Reply = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_Mail = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Reply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.mailbox_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_MailControls.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_Mail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_SignOut);
            this.panel1.Controls.Add(this.btn_Compose);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pn_MailControls);
            this.panel1.Location = new System.Drawing.Point(24, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19F);
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "TTMail";
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignOut.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_SignOut.Location = new System.Drawing.Point(776, 7);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(112, 33);
            this.btn_SignOut.TabIndex = 16;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_Compose
            // 
            this.btn_Compose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Compose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compose.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Compose.Location = new System.Drawing.Point(0, 50);
            this.btn_Compose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Compose.Name = "btn_Compose";
            this.btn_Compose.Size = new System.Drawing.Size(168, 34);
            this.btn_Compose.TabIndex = 7;
            this.btn_Compose.Text = "Soạn thư";
            this.btn_Compose.UseVisualStyleBackColor = true;
            this.btn_Compose.Click += new System.EventHandler(this.btn_Compose_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search.Location = new System.Drawing.Point(651, 7);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 33);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Search.Location = new System.Drawing.Point(188, 9);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(444, 28);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cb_MailType);
            this.panel2.Controls.Add(this.chb_SelectAll);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.lbl_Count);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_Selected);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(187, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 34);
            this.panel2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_MailType
            // 
            this.cb_MailType.BackColor = System.Drawing.Color.White;
            this.cb_MailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MailType.Font = new System.Drawing.Font("Calibri", 10F);
            this.cb_MailType.FormattingEnabled = true;
            this.cb_MailType.Location = new System.Drawing.Point(53, 5);
            this.cb_MailType.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MailType.Name = "cb_MailType";
            this.cb_MailType.Size = new System.Drawing.Size(163, 29);
            this.cb_MailType.TabIndex = 24;
            this.cb_MailType.SelectedIndexChanged += new System.EventHandler(this.cb_MailType_SelectedIndexChanged);
            // 
            // chb_SelectAll
            // 
            this.chb_SelectAll.AutoSize = true;
            this.chb_SelectAll.Location = new System.Drawing.Point(19, 11);
            this.chb_SelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.chb_SelectAll.Name = "chb_SelectAll";
            this.chb_SelectAll.Size = new System.Drawing.Size(18, 17);
            this.chb_SelectAll.TabIndex = 27;
            this.chb_SelectAll.UseVisualStyleBackColor = true;
            this.chb_SelectAll.CheckedChanged += new System.EventHandler(this.chb_SelectAll_CheckedChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Delete.Location = new System.Drawing.Point(255, 4);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(56, 30);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbl_Count.Location = new System.Drawing.Point(427, 10);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(19, 21);
            this.lbl_Count.TabIndex = 23;
            this.lbl_Count.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(333, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tổng cộng:";
            // 
            // lbl_Selected
            // 
            this.lbl_Selected.AutoSize = true;
            this.lbl_Selected.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbl_Selected.Location = new System.Drawing.Point(556, 10);
            this.lbl_Selected.Name = "lbl_Selected";
            this.lbl_Selected.Size = new System.Drawing.Size(19, 21);
            this.lbl_Selected.TabIndex = 21;
            this.lbl_Selected.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(477, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đã chọn:";
            // 
            // pn_MailControls
            // 
            this.pn_MailControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_MailControls.Controls.Add(this.lbl_MailIndex);
            this.pn_MailControls.Controls.Add(this.btn_Reply);
            this.pn_MailControls.Controls.Add(this.btn_Back);
            this.pn_MailControls.Controls.Add(this.btn_Forward);
            this.pn_MailControls.Location = new System.Drawing.Point(187, 49);
            this.pn_MailControls.Margin = new System.Windows.Forms.Padding(4);
            this.pn_MailControls.Name = "pn_MailControls";
            this.pn_MailControls.Size = new System.Drawing.Size(701, 34);
            this.pn_MailControls.TabIndex = 22;
            // 
            // lbl_MailIndex
            // 
            this.lbl_MailIndex.AutoSize = true;
            this.lbl_MailIndex.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbl_MailIndex.Location = new System.Drawing.Point(63, 10);
            this.lbl_MailIndex.Name = "lbl_MailIndex";
            this.lbl_MailIndex.Size = new System.Drawing.Size(177, 21);
            this.lbl_MailIndex.TabIndex = 11;
            this.lbl_MailIndex.Text = "2 trong tổng số 100 thư";
            // 
            // btn_Reply
            // 
            this.btn_Reply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reply.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Reply.Location = new System.Drawing.Point(464, 1);
            this.btn_Reply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reply.Name = "btn_Reply";
            this.btn_Reply.Size = new System.Drawing.Size(112, 33);
            this.btn_Reply.TabIndex = 24;
            this.btn_Reply.Text = "Trả lời";
            this.btn_Reply.UseVisualStyleBackColor = true;
            this.btn_Reply.Click += new System.EventHandler(this.btn_Reply_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(-1, 1);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(47, 33);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "←";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Forward.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Forward.Location = new System.Drawing.Point(589, 1);
            this.btn_Forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(112, 33);
            this.btn_Forward.TabIndex = 23;
            this.btn_Forward.Text = "Chuyển tiếp";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pn_Mail);
            this.panel3.Location = new System.Drawing.Point(211, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 436);
            this.panel3.TabIndex = 2;
            // 
            // pn_Mail
            // 
            this.pn_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Mail.BackColor = System.Drawing.Color.White;
            this.pn_Mail.Controls.Add(this.lvData);
            this.pn_Mail.Controls.Add(this.dataGridView);
            this.pn_Mail.Controls.Add(this.webBrowser);
            this.pn_Mail.Location = new System.Drawing.Point(0, 0);
            this.pn_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Mail.Name = "pn_Mail";
            this.pn_Mail.Size = new System.Drawing.Size(699, 434);
            this.pn_Mail.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Subject,
            this.Date});
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(3, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(693, 428);
            this.dataGridView.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(693, 428);
            this.webBrowser.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.tsmi_Reply,
            this.tsmi_Delete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(120, 76);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // tsmi_Reply
            // 
            this.tsmi_Reply.Name = "tsmi_Reply";
            this.tsmi_Reply.Size = new System.Drawing.Size(119, 24);
            this.tsmi_Reply.Text = "Trả lời";
            // 
            // tsmi_Delete
            // 
            this.tsmi_Delete.Name = "tsmi_Delete";
            this.tsmi_Delete.Size = new System.Drawing.Size(119, 24);
            this.tsmi_Delete.Text = "Xóa";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.mailbox_btn);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(24, 105);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 434);
            this.panel4.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Calibri", 10F);
            this.button10.Location = new System.Drawing.Point(-1, 265);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(169, 38);
            this.button10.TabIndex = 15;
            this.button10.Text = "Thùng rác";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // mailbox_btn
            // 
            this.mailbox_btn.Font = new System.Drawing.Font("Calibri", 10F);
            this.mailbox_btn.Location = new System.Drawing.Point(-1, -1);
            this.mailbox_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailbox_btn.Name = "mailbox_btn";
            this.mailbox_btn.Size = new System.Drawing.Size(169, 38);
            this.mailbox_btn.TabIndex = 14;
            this.mailbox_btn.Text = "Hộp thư đến";
            this.mailbox_btn.UseVisualStyleBackColor = true;
            this.mailbox_btn.Click += new System.EventHandler(this.mailbox_btn_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Calibri", 10F);
            this.button8.Location = new System.Drawing.Point(-1, 220);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 38);
            this.button8.TabIndex = 13;
            this.button8.Text = "Spam";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 10F);
            this.button7.Location = new System.Drawing.Point(-1, 176);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 38);
            this.button7.TabIndex = 12;
            this.button7.Text = "Quan trọng";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 10F);
            this.button6.Location = new System.Drawing.Point(-1, 132);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 38);
            this.button6.TabIndex = 11;
            this.button6.Text = "Thư nháp";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 10F);
            this.button5.Location = new System.Drawing.Point(-1, 87);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 38);
            this.button5.TabIndex = 10;
            this.button5.Text = "Đã gửi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10F);
            this.button4.Location = new System.Drawing.Point(-1, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "Có gắn dấu sao";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Người gửi";
            this.Sender.MinimumWidth = 6;
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Nội dung";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày gửi";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(3, 3);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(693, 426);
            this.lvData.TabIndex = 2;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Người gửi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày gửi";
            // 
            // frm_MailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_MailBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hộp thư";
            this.Load += new System.EventHandler(this.frm_MailBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_MailControls.ResumeLayout(false);
            this.pn_MailControls.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pn_Mail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Compose;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Reply;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Delete;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Panel pn_MailControls;
        private System.Windows.Forms.Label lbl_MailIndex;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pn_Mail;
        private System.Windows.Forms.Button btn_Reply;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chb_SelectAll;
        public System.Windows.Forms.ComboBox cb_MailType;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button mailbox_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}