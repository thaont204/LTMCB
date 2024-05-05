namespace Lab3
{
    partial class B4_TCP_Server
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
            this.ServerLog = new System.Windows.Forms.RichTextBox();
            this.Listen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerLog
            // 
            this.ServerLog.Location = new System.Drawing.Point(12, 76);
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.Size = new System.Drawing.Size(742, 338);
            this.ServerLog.TabIndex = 0;
            this.ServerLog.Text = "";
            // 
            // Listen_btn
            // 
            this.Listen_btn.Location = new System.Drawing.Point(535, 27);
            this.Listen_btn.Name = "Listen_btn";
            this.Listen_btn.Size = new System.Drawing.Size(219, 43);
            this.Listen_btn.TabIndex = 1;
            this.Listen_btn.Text = "Listen";
            this.Listen_btn.UseVisualStyleBackColor = true;
            this.Listen_btn.Click += new System.EventHandler(this.Listen_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listen_btn);
            this.Controls.Add(this.ServerLog);
            this.Name = "B4_TCP_Server";
            this.Text = "Bai04Lab03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ServerLog;
        private System.Windows.Forms.Button Listen_btn;
    }
}