namespace Lab2
{
    partial class Lab2
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
            btn_Bai1 = new Button();
            btn_Bai2 = new Button();
            btn_Bai3 = new Button();
            btn_Bai4 = new Button();
            btn_Bai5 = new Button();
            SuspendLayout();
            // 
            // btn_Bai1
            // 
            btn_Bai1.Location = new Point(151, 95);
            btn_Bai1.Name = "btn_Bai1";
            btn_Bai1.Size = new Size(94, 29);
            btn_Bai1.TabIndex = 0;
            btn_Bai1.Text = "Bài 1";
            btn_Bai1.UseVisualStyleBackColor = true;
            btn_Bai1.Click += btn_Bai1_Click;
            // 
            // btn_Bai2
            // 
            btn_Bai2.Location = new Point(439, 95);
            btn_Bai2.Name = "btn_Bai2";
            btn_Bai2.Size = new Size(94, 29);
            btn_Bai2.TabIndex = 1;
            btn_Bai2.Text = "Bài 2";
            btn_Bai2.UseVisualStyleBackColor = true;
            btn_Bai2.Click += btn_Bai2_Click;
            // 
            // btn_Bai3
            // 
            btn_Bai3.Location = new Point(151, 178);
            btn_Bai3.Name = "btn_Bai3";
            btn_Bai3.Size = new Size(94, 29);
            btn_Bai3.TabIndex = 2;
            btn_Bai3.Text = "Bài 3";
            btn_Bai3.UseVisualStyleBackColor = true;
            btn_Bai3.Click += btn_Bai3_Click;
            // 
            // btn_Bai4
            // 
            btn_Bai4.Location = new Point(439, 178);
            btn_Bai4.Name = "btn_Bai4";
            btn_Bai4.Size = new Size(94, 29);
            btn_Bai4.TabIndex = 3;
            btn_Bai4.Text = "Bài 4";
            btn_Bai4.UseVisualStyleBackColor = true;
            btn_Bai4.Click += btn_Bai4_Click;
            // 
            // btn_Bai5
            // 
            btn_Bai5.Location = new Point(151, 263);
            btn_Bai5.Name = "btn_Bai5";
            btn_Bai5.Size = new Size(94, 29);
            btn_Bai5.TabIndex = 4;
            btn_Bai5.Text = "Bài 5";
            btn_Bai5.UseVisualStyleBackColor = true;
            btn_Bai5.Click += btn_Bai5_Click;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Bai5);
            Controls.Add(btn_Bai4);
            Controls.Add(btn_Bai3);
            Controls.Add(btn_Bai2);
            Controls.Add(btn_Bai1);
            Name = "Lab2";
            Text = "Lab2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Bai1;
        private Button btn_Bai2;
        private Button btn_Bai3;
        private Button btn_Bai4;
        private Button btn_Bai5;
    }
}