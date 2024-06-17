namespace MailApp
{
    partial class frm_Compose
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_HTML = new System.Windows.Forms.CheckBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_SSL = new System.Windows.Forms.CheckBox();
            this.txt_BCC = new System.Windows.Forms.TextBox();
            this.txt_SMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CC = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Files = new System.Windows.Forms.TextBox();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chb_HTML);
            this.panel1.Controls.Add(this.txt_Port);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chb_SSL);
            this.panel1.Controls.Add(this.txt_BCC);
            this.panel1.Controls.Add(this.txt_SMTP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Subject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_To);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_CC);
            this.panel1.Location = new System.Drawing.Point(24, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 165);
            this.panel1.TabIndex = 1;
            // 
            // chb_HTML
            // 
            this.chb_HTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_HTML.AutoSize = true;
            this.chb_HTML.Location = new System.Drawing.Point(786, 143);
            this.chb_HTML.Margin = new System.Windows.Forms.Padding(4);
            this.chb_HTML.Name = "chb_HTML";
            this.chb_HTML.Size = new System.Drawing.Size(101, 20);
            this.chb_HTML.TabIndex = 19;
            this.chb_HTML.Text = "HTML Body";
            this.chb_HTML.UseVisualStyleBackColor = true;
            // 
            // txt_Port
            // 
            this.txt_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Port.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Port.Location = new System.Drawing.Point(712, 98);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(175, 28);
            this.txt_Port.TabIndex = 25;
            this.txt_Port.Text = "465";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(712, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "SMTP Server:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(28, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "BCC:";
            // 
            // chb_SSL
            // 
            this.chb_SSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_SSL.AutoSize = true;
            this.chb_SSL.Checked = true;
            this.chb_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_SSL.Location = new System.Drawing.Point(721, 143);
            this.chb_SSL.Margin = new System.Windows.Forms.Padding(4);
            this.chb_SSL.Name = "chb_SSL";
            this.chb_SSL.Size = new System.Drawing.Size(54, 20);
            this.chb_SSL.TabIndex = 23;
            this.chb_SSL.Text = "SSL";
            this.chb_SSL.UseVisualStyleBackColor = true;
            // 
            // txt_BCC
            // 
            this.txt_BCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BCC.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_BCC.Location = new System.Drawing.Point(79, 94);
            this.txt_BCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BCC.Name = "txt_BCC";
            this.txt_BCC.Size = new System.Drawing.Size(613, 28);
            this.txt_BCC.TabIndex = 22;
            // 
            // txt_SMTP
            // 
            this.txt_SMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SMTP.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_SMTP.Location = new System.Drawing.Point(712, 36);
            this.txt_SMTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.Size = new System.Drawing.Size(175, 28);
            this.txt_SMTP.TabIndex = 22;
            this.txt_SMTP.Text = "smtp.gmail.com";
            this.txt_SMTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(712, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subject:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Subject.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Subject.Location = new System.Drawing.Point(79, 134);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(613, 28);
            this.txt_Subject.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "To:";
            // 
            // txt_To
            // 
            this.txt_To.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_To.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_To.Location = new System.Drawing.Point(79, 12);
            this.txt_To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(613, 28);
            this.txt_To.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(39, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "CC:";
            // 
            // txt_CC
            // 
            this.txt_CC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CC.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_CC.Location = new System.Drawing.Point(79, 53);
            this.txt_CC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CC.Name = "txt_CC";
            this.txt_CC.Size = new System.Drawing.Size(613, 28);
            this.txt_CC.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txt_Message);
            this.panel3.Controls.Add(this.txt_Files);
            this.panel3.Controls.Add(this.btn_Attach);
            this.panel3.Controls.Add(this.btn_Send);
            this.panel3.Location = new System.Drawing.Point(24, 188);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 353);
            this.panel3.TabIndex = 3;
            // 
            // txt_Message
            // 
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Message.Location = new System.Drawing.Point(0, 0);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(888, 301);
            this.txt_Message.TabIndex = 16;
            // 
            // txt_Files
            // 
            this.txt_Files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Files.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Files.Location = new System.Drawing.Point(0, 320);
            this.txt_Files.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Files.Name = "txt_Files";
            this.txt_Files.Size = new System.Drawing.Size(591, 28);
            this.txt_Files.TabIndex = 15;
            // 
            // btn_Attach
            // 
            this.btn_Attach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Attach.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Attach.Location = new System.Drawing.Point(611, 319);
            this.btn_Attach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(144, 33);
            this.btn_Attach.TabIndex = 9;
            this.btn_Attach.Text = "Đính kèm file";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Send.Location = new System.Drawing.Point(772, 319);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(117, 33);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "Gửi";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // frm_Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Compose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CC;
        private System.Windows.Forms.CheckBox chb_HTML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_SSL;
        private System.Windows.Forms.TextBox txt_SMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Port;
    }
}