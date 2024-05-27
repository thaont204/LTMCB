namespace Lab4
{
    partial class Bai3
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
            this.Content_rtb = new System.Windows.Forms.RichTextBox();
            this.Path_tb = new System.Windows.Forms.TextBox();
            this.URL_tb = new System.Windows.Forms.TextBox();
            this.Download_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content_rtb
            // 
            this.Content_rtb.Location = new System.Drawing.Point(13, 70);
            this.Content_rtb.Name = "Content_rtb";
            this.Content_rtb.Size = new System.Drawing.Size(775, 368);
            this.Content_rtb.TabIndex = 7;
            this.Content_rtb.Text = "";
            // 
            // Path_tb
            // 
            this.Path_tb.Location = new System.Drawing.Point(13, 41);
            this.Path_tb.Name = "Path_tb";
            this.Path_tb.Size = new System.Drawing.Size(650, 22);
            this.Path_tb.TabIndex = 6;
            // 
            // URL_tb
            // 
            this.URL_tb.Location = new System.Drawing.Point(13, 12);
            this.URL_tb.Name = "URL_tb";
            this.URL_tb.Size = new System.Drawing.Size(650, 22);
            this.URL_tb.TabIndex = 5;
            // 
            // Download_btn
            // 
            this.Download_btn.Location = new System.Drawing.Point(669, 12);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(119, 33);
            this.Download_btn.TabIndex = 4;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = true;
            this.Download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content_rtb);
            this.Controls.Add(this.Path_tb);
            this.Controls.Add(this.URL_tb);
            this.Controls.Add(this.Download_btn);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Content_rtb;
        private System.Windows.Forms.TextBox Path_tb;
        private System.Windows.Forms.TextBox URL_tb;
        private System.Windows.Forms.Button Download_btn;
    }
}