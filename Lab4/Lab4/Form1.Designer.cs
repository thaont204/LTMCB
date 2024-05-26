namespace Lab4
{
    partial class Form1
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
            this.Bai1_btn = new System.Windows.Forms.Button();
            this.Bai2_btn = new System.Windows.Forms.Button();
            this.Bai3_btn = new System.Windows.Forms.Button();
            this.Bai4_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai1_btn
            // 
            this.Bai1_btn.Location = new System.Drawing.Point(134, 84);
            this.Bai1_btn.Name = "Bai1_btn";
            this.Bai1_btn.Size = new System.Drawing.Size(168, 66);
            this.Bai1_btn.TabIndex = 0;
            this.Bai1_btn.Text = "Bài 1";
            this.Bai1_btn.UseVisualStyleBackColor = true;
            this.Bai1_btn.Click += new System.EventHandler(this.Bai1_btn_Click);
            // 
            // Bai2_btn
            // 
            this.Bai2_btn.Location = new System.Drawing.Point(508, 84);
            this.Bai2_btn.Name = "Bai2_btn";
            this.Bai2_btn.Size = new System.Drawing.Size(168, 66);
            this.Bai2_btn.TabIndex = 1;
            this.Bai2_btn.Text = "Bài 2";
            this.Bai2_btn.UseVisualStyleBackColor = true;
            this.Bai2_btn.Click += new System.EventHandler(this.Bai2_btn_Click);
            // 
            // Bai3_btn
            // 
            this.Bai3_btn.Location = new System.Drawing.Point(134, 239);
            this.Bai3_btn.Name = "Bai3_btn";
            this.Bai3_btn.Size = new System.Drawing.Size(168, 66);
            this.Bai3_btn.TabIndex = 2;
            this.Bai3_btn.Text = "Bài 3";
            this.Bai3_btn.UseVisualStyleBackColor = true;
            this.Bai3_btn.Click += new System.EventHandler(this.Bai3_btn_Click);
            // 
            // Bai4_btn
            // 
            this.Bai4_btn.Location = new System.Drawing.Point(508, 239);
            this.Bai4_btn.Name = "Bai4_btn";
            this.Bai4_btn.Size = new System.Drawing.Size(168, 66);
            this.Bai4_btn.TabIndex = 3;
            this.Bai4_btn.Text = "Bài 4";
            this.Bai4_btn.UseVisualStyleBackColor = true;
            this.Bai4_btn.Click += new System.EventHandler(this.Bai4_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bai4_btn);
            this.Controls.Add(this.Bai3_btn);
            this.Controls.Add(this.Bai2_btn);
            this.Controls.Add(this.Bai1_btn);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai1_btn;
        private System.Windows.Forms.Button Bai2_btn;
        private System.Windows.Forms.Button Bai3_btn;
        private System.Windows.Forms.Button Bai4_btn;
    }
}

