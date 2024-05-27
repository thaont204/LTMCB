namespace Lab4
{
    partial class HTML_src
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
            this.Source_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Source_box
            // 
            this.Source_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Source_box.Location = new System.Drawing.Point(0, 0);
            this.Source_box.Name = "Source_box";
            this.Source_box.Size = new System.Drawing.Size(800, 450);
            this.Source_box.TabIndex = 0;
            this.Source_box.Text = "";
            // 
            // HTML_src
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Source_box);
            this.Name = "HTML_src";
            this.Text = "HTML src view";
            this.Load += new System.EventHandler(this.HTML_src_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Source_box;
    }
}