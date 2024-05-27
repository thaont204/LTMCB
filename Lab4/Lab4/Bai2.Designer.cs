namespace Lab4
{
    partial class Bai2
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
            this.Post_btn = new System.Windows.Forms.Button();
            this.URL_tb = new System.Windows.Forms.TextBox();
            this.Data_tb = new System.Windows.Forms.TextBox();
            this.Content_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Post_btn
            // 
            this.Post_btn.Location = new System.Drawing.Point(669, 12);
            this.Post_btn.Name = "Post_btn";
            this.Post_btn.Size = new System.Drawing.Size(119, 33);
            this.Post_btn.TabIndex = 0;
            this.Post_btn.Text = "POST";
            this.Post_btn.UseVisualStyleBackColor = true;
            this.Post_btn.Click += new System.EventHandler(this.Post_btn_Click);
            // 
            // URL_tb
            // 
            this.URL_tb.Location = new System.Drawing.Point(13, 12);
            this.URL_tb.Name = "URL_tb";
            this.URL_tb.Size = new System.Drawing.Size(650, 22);
            this.URL_tb.TabIndex = 1;
            // 
            // Data_tb
            // 
            this.Data_tb.Location = new System.Drawing.Point(13, 41);
            this.Data_tb.Name = "Data_tb";
            this.Data_tb.Size = new System.Drawing.Size(650, 22);
            this.Data_tb.TabIndex = 2;
            // 
            // Content_rtb
            // 
            this.Content_rtb.Location = new System.Drawing.Point(13, 70);
            this.Content_rtb.Name = "Content_rtb";
            this.Content_rtb.Size = new System.Drawing.Size(775, 368);
            this.Content_rtb.TabIndex = 3;
            this.Content_rtb.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content_rtb);
            this.Controls.Add(this.Data_tb);
            this.Controls.Add(this.URL_tb);
            this.Controls.Add(this.Post_btn);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Post_btn;
        private System.Windows.Forms.TextBox URL_tb;
        private System.Windows.Forms.TextBox Data_tb;
        private System.Windows.Forms.RichTextBox Content_rtb;
    }
}