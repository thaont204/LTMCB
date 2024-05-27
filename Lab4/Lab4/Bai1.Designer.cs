namespace Lab4
{
    partial class Bai1
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
            this.URL_tb = new System.Windows.Forms.TextBox();
            this.Get_btn = new System.Windows.Forms.Button();
            this.Content_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // URL_tb
            // 
            this.URL_tb.Location = new System.Drawing.Point(12, 9);
            this.URL_tb.Name = "URL_tb";
            this.URL_tb.Size = new System.Drawing.Size(652, 22);
            this.URL_tb.TabIndex = 0;
            // 
            // Get_btn
            // 
            this.Get_btn.Location = new System.Drawing.Point(676, 6);
            this.Get_btn.Name = "Get_btn";
            this.Get_btn.Size = new System.Drawing.Size(112, 29);
            this.Get_btn.TabIndex = 1;
            this.Get_btn.Text = "GET";
            this.Get_btn.UseVisualStyleBackColor = true;
            this.Get_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // Content_rtb
            // 
            this.Content_rtb.Location = new System.Drawing.Point(13, 42);
            this.Content_rtb.Name = "Content_rtb";
            this.Content_rtb.Size = new System.Drawing.Size(775, 396);
            this.Content_rtb.TabIndex = 2;
            this.Content_rtb.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content_rtb);
            this.Controls.Add(this.Get_btn);
            this.Controls.Add(this.URL_tb);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_tb;
        private System.Windows.Forms.Button Get_btn;
        private System.Windows.Forms.RichTextBox Content_rtb;
    }
}