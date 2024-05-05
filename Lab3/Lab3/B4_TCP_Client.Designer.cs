namespace Lab3
{
    partial class B4_TCP_Client
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
            this.Chat_box = new System.Windows.Forms.RichTextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Mess_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chat_box
            // 
            this.Chat_box.Location = new System.Drawing.Point(12, 12);
            this.Chat_box.Name = "Chat_box";
            this.Chat_box.Size = new System.Drawing.Size(735, 285);
            this.Chat_box.TabIndex = 0;
            this.Chat_box.Text = "";
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(587, 387);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(160, 37);
            this.Send_btn.TabIndex = 1;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(12, 336);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(174, 22);
            this.Name_box.TabIndex = 2;
            // 
            // Mess_box
            // 
            this.Mess_box.Location = new System.Drawing.Point(12, 402);
            this.Mess_box.Name = "Mess_box";
            this.Mess_box.Size = new System.Drawing.Size(548, 22);
            this.Mess_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Messages";
            // 
            // B4_TCP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mess_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Chat_box);
            this.Name = "B4_TCP_Client";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.B4_TCP_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Chat_box;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Mess_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}