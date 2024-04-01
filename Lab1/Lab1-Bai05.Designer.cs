namespace Lab1_22521371_NguyenThanhThao
{
    partial class Lab1_Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDiem = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DiemTB = new System.Windows.Forms.Label();
            this.XL = new System.Windows.Forms.Label();
            this.maxscore = new System.Windows.Forms.Label();
            this.minscore = new System.Windows.Forms.Label();
            this.numDau = new System.Windows.Forms.Label();
            this.numKodau = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbm1 = new System.Windows.Forms.Label();
            this.lbm2 = new System.Windows.Forms.Label();
            this.lbm3 = new System.Windows.Forms.Label();
            this.lbm4 = new System.Windows.Forms.Label();
            this.lbm5 = new System.Windows.Forms.Label();
            this.lbm6 = new System.Windows.Forms.Label();
            this.lbm7 = new System.Windows.Forms.Label();
            this.lbm8 = new System.Windows.Forms.Label();
            this.lbm9 = new System.Windows.Forms.Label();
            this.lbm10 = new System.Windows.Forms.Label();
            this.lbm11 = new System.Windows.Forms.Label();
            this.lbm12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm:";
            // 
            // inputDiem
            // 
            this.inputDiem.Location = new System.Drawing.Point(202, 37);
            this.inputDiem.Name = "inputDiem";
            this.inputDiem.Size = new System.Drawing.Size(487, 22);
            this.inputDiem.TabIndex = 2;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(491, 76);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(83, 32);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách môn học và điểm";
            // 
            // DiemTB
            // 
            this.DiemTB.AutoSize = true;
            this.DiemTB.Location = new System.Drawing.Point(52, 311);
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Size = new System.Drawing.Size(104, 16);
            this.DiemTB.TabIndex = 6;
            this.DiemTB.Text = "Điểm trung bình: ";
            // 
            // XL
            // 
            this.XL.AutoSize = true;
            this.XL.Location = new System.Drawing.Point(410, 311);
            this.XL.Name = "XL";
            this.XL.Size = new System.Drawing.Size(107, 16);
            this.XL.TabIndex = 7;
            this.XL.Text = "Xếp loại học lực: ";
            // 
            // maxscore
            // 
            this.maxscore.AutoSize = true;
            this.maxscore.Location = new System.Drawing.Point(52, 359);
            this.maxscore.Name = "maxscore";
            this.maxscore.Size = new System.Drawing.Size(144, 16);
            this.maxscore.TabIndex = 8;
            this.maxscore.Text = "Môn có điểm cao nhất: ";
            // 
            // minscore
            // 
            this.minscore.AutoSize = true;
            this.minscore.Location = new System.Drawing.Point(410, 359);
            this.minscore.Name = "minscore";
            this.minscore.Size = new System.Drawing.Size(147, 16);
            this.minscore.TabIndex = 9;
            this.minscore.Text = "Môn có điểm thấp nhất: ";
            // 
            // numDau
            // 
            this.numDau.AutoSize = true;
            this.numDau.Location = new System.Drawing.Point(52, 404);
            this.numDau.Name = "numDau";
            this.numDau.Size = new System.Drawing.Size(85, 16);
            this.numDau.TabIndex = 10;
            this.numDau.Text = "Số môn đậu: ";
            // 
            // numKodau
            // 
            this.numKodau.AutoSize = true;
            this.numKodau.Location = new System.Drawing.Point(410, 404);
            this.numKodau.Name = "numKodau";
            this.numKodau.Size = new System.Drawing.Size(125, 16);
            this.numKodau.TabIndex = 11;
            this.numKodau.Text = "Số môn không đậu: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 76);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 170);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbm1
            // 
            this.lbm1.AutoSize = true;
            this.lbm1.Location = new System.Drawing.Point(82, 150);
            this.lbm1.Name = "lbm1";
            this.lbm1.Size = new System.Drawing.Size(49, 16);
            this.lbm1.TabIndex = 15;
            this.lbm1.Text = "Môn 1: ";
            // 
            // lbm2
            // 
            this.lbm2.AutoSize = true;
            this.lbm2.Location = new System.Drawing.Point(227, 150);
            this.lbm2.Name = "lbm2";
            this.lbm2.Size = new System.Drawing.Size(49, 16);
            this.lbm2.TabIndex = 16;
            this.lbm2.Text = "Môn 2: ";
            // 
            // lbm3
            // 
            this.lbm3.AutoSize = true;
            this.lbm3.Location = new System.Drawing.Point(380, 150);
            this.lbm3.Name = "lbm3";
            this.lbm3.Size = new System.Drawing.Size(49, 16);
            this.lbm3.TabIndex = 17;
            this.lbm3.Text = "Môn 3: ";
            // 
            // lbm4
            // 
            this.lbm4.AutoSize = true;
            this.lbm4.Location = new System.Drawing.Point(529, 150);
            this.lbm4.Name = "lbm4";
            this.lbm4.Size = new System.Drawing.Size(49, 16);
            this.lbm4.TabIndex = 18;
            this.lbm4.Text = "Môn 4: ";
            // 
            // lbm5
            // 
            this.lbm5.AutoSize = true;
            this.lbm5.Location = new System.Drawing.Point(82, 190);
            this.lbm5.Name = "lbm5";
            this.lbm5.Size = new System.Drawing.Size(49, 16);
            this.lbm5.TabIndex = 19;
            this.lbm5.Text = "Môn 5: ";
            // 
            // lbm6
            // 
            this.lbm6.AutoSize = true;
            this.lbm6.Location = new System.Drawing.Point(227, 191);
            this.lbm6.Name = "lbm6";
            this.lbm6.Size = new System.Drawing.Size(49, 16);
            this.lbm6.TabIndex = 20;
            this.lbm6.Text = "Môn 6: ";
            // 
            // lbm7
            // 
            this.lbm7.AutoSize = true;
            this.lbm7.Location = new System.Drawing.Point(380, 191);
            this.lbm7.Name = "lbm7";
            this.lbm7.Size = new System.Drawing.Size(49, 16);
            this.lbm7.TabIndex = 21;
            this.lbm7.Text = "Môn 7: ";
            // 
            // lbm8
            // 
            this.lbm8.AutoSize = true;
            this.lbm8.Location = new System.Drawing.Point(532, 190);
            this.lbm8.Name = "lbm8";
            this.lbm8.Size = new System.Drawing.Size(49, 16);
            this.lbm8.TabIndex = 22;
            this.lbm8.Text = "Môn 8: ";
            // 
            // lbm9
            // 
            this.lbm9.AutoSize = true;
            this.lbm9.Location = new System.Drawing.Point(82, 227);
            this.lbm9.Name = "lbm9";
            this.lbm9.Size = new System.Drawing.Size(49, 16);
            this.lbm9.TabIndex = 23;
            this.lbm9.Text = "Môn 9: ";
            // 
            // lbm10
            // 
            this.lbm10.AutoSize = true;
            this.lbm10.Location = new System.Drawing.Point(233, 227);
            this.lbm10.Name = "lbm10";
            this.lbm10.Size = new System.Drawing.Size(56, 16);
            this.lbm10.TabIndex = 24;
            this.lbm10.Text = "Môn 10: ";
            // 
            // lbm11
            // 
            this.lbm11.AutoSize = true;
            this.lbm11.Location = new System.Drawing.Point(383, 227);
            this.lbm11.Name = "lbm11";
            this.lbm11.Size = new System.Drawing.Size(56, 16);
            this.lbm11.TabIndex = 25;
            this.lbm11.Text = "Môn 11: ";
            // 
            // lbm12
            // 
            this.lbm12.AutoSize = true;
            this.lbm12.Location = new System.Drawing.Point(532, 226);
            this.lbm12.Name = "lbm12";
            this.lbm12.Size = new System.Drawing.Size(56, 16);
            this.lbm12.TabIndex = 26;
            this.lbm12.Text = "Môn 12: ";
            // 
            // Lab1_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbm12);
            this.Controls.Add(this.lbm11);
            this.Controls.Add(this.lbm10);
            this.Controls.Add(this.lbm9);
            this.Controls.Add(this.lbm8);
            this.Controls.Add(this.lbm7);
            this.Controls.Add(this.lbm6);
            this.Controls.Add(this.lbm5);
            this.Controls.Add(this.lbm4);
            this.Controls.Add(this.lbm3);
            this.Controls.Add(this.lbm2);
            this.Controls.Add(this.lbm1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.numKodau);
            this.Controls.Add(this.numDau);
            this.Controls.Add(this.minscore);
            this.Controls.Add(this.maxscore);
            this.Controls.Add(this.XL);
            this.Controls.Add(this.DiemTB);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.inputDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Lab1_Bai05";
            this.Text = "Lab1_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDiem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DiemTB;
        private System.Windows.Forms.Label XL;
        private System.Windows.Forms.Label maxscore;
        private System.Windows.Forms.Label minscore;
        private System.Windows.Forms.Label numDau;
        private System.Windows.Forms.Label numKodau;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbm1;
        private System.Windows.Forms.Label lbm2;
        private System.Windows.Forms.Label lbm3;
        private System.Windows.Forms.Label lbm4;
        private System.Windows.Forms.Label lbm5;
        private System.Windows.Forms.Label lbm6;
        private System.Windows.Forms.Label lbm7;
        private System.Windows.Forms.Label lbm8;
        private System.Windows.Forms.Label lbm9;
        private System.Windows.Forms.Label lbm10;
        private System.Windows.Forms.Label lbm11;
        private System.Windows.Forms.Label lbm12;
    }
}