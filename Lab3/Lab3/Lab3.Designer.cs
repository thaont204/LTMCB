namespace Lab3
{
    partial class Lab3
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
            this.btn_Bai1 = new System.Windows.Forms.Button();
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.btn_Bai3 = new System.Windows.Forms.Button();
            this.btn_Bai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai1
            // 
            this.btn_Bai1.Location = new System.Drawing.Point(107, 114);
            this.btn_Bai1.Name = "btn_Bai1";
            this.btn_Bai1.Size = new System.Drawing.Size(141, 58);
            this.btn_Bai1.TabIndex = 0;
            this.btn_Bai1.Text = "Bài 01";
            this.btn_Bai1.UseVisualStyleBackColor = true;
            this.btn_Bai1.Click += new System.EventHandler(this.btn_Bai1_Click);
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.Location = new System.Drawing.Point(463, 114);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(143, 58);
            this.btn_Bai2.TabIndex = 1;
            this.btn_Bai2.Text = "Bài 02";
            this.btn_Bai2.UseVisualStyleBackColor = true;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // btn_Bai3
            // 
            this.btn_Bai3.Location = new System.Drawing.Point(107, 247);
            this.btn_Bai3.Name = "btn_Bai3";
            this.btn_Bai3.Size = new System.Drawing.Size(141, 59);
            this.btn_Bai3.TabIndex = 2;
            this.btn_Bai3.Text = "Bài 03";
            this.btn_Bai3.UseVisualStyleBackColor = true;
            this.btn_Bai3.Click += new System.EventHandler(this.btn_Bai3_Click);
            // 
            // btn_Bai4
            // 
            this.btn_Bai4.Location = new System.Drawing.Point(463, 247);
            this.btn_Bai4.Name = "btn_Bai4";
            this.btn_Bai4.Size = new System.Drawing.Size(143, 59);
            this.btn_Bai4.TabIndex = 3;
            this.btn_Bai4.Text = "Bài 04";
            this.btn_Bai4.UseVisualStyleBackColor = true;
            this.btn_Bai4.Click += new System.EventHandler(this.btn_Bai4_Click);
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Bai4);
            this.Controls.Add(this.btn_Bai3);
            this.Controls.Add(this.btn_Bai2);
            this.Controls.Add(this.btn_Bai1);
            this.Name = "Lab3";
            this.Text = "Lab3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai1;
        private System.Windows.Forms.Button btn_Bai2;
        private System.Windows.Forms.Button btn_Bai3;
        private System.Windows.Forms.Button btn_Bai4;
    }
}

