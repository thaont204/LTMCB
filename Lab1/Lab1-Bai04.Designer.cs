namespace Lab1_22521371_NguyenThanhThao
{
    partial class Lab1_Bai04
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.input = new System.Windows.Forms.TextBox();
            this.HeHienTai = new System.Windows.Forms.ComboBox();
            this.HeMuonDoi = new System.Windows.Forms.ComboBox();
            this.btn_do = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập một số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sang";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(717, 203);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(229, 89);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(439, 22);
            this.input.TabIndex = 6;
            // 
            // HeHienTai
            // 
            this.HeHienTai.FormattingEnabled = true;
            this.HeHienTai.Items.AddRange(new object[] {
            "DEC",
            "BIN",
            "HEX"});
            this.HeHienTai.Location = new System.Drawing.Point(229, 142);
            this.HeHienTai.Name = "HeHienTai";
            this.HeHienTai.Size = new System.Drawing.Size(184, 24);
            this.HeHienTai.TabIndex = 7;
            // 
            // HeMuonDoi
            // 
            this.HeMuonDoi.FormattingEnabled = true;
            this.HeMuonDoi.Items.AddRange(new object[] {
            "DEC",
            "BIN",
            "HEX"});
            this.HeMuonDoi.Location = new System.Drawing.Point(464, 142);
            this.HeMuonDoi.Name = "HeMuonDoi";
            this.HeMuonDoi.Size = new System.Drawing.Size(204, 24);
            this.HeMuonDoi.TabIndex = 8;
            // 
            // btn_do
            // 
            this.btn_do.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_do.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_do.Location = new System.Drawing.Point(229, 181);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(439, 34);
            this.btn_do.TabIndex = 9;
            this.btn_do.Text = "Thực hiện";
            this.btn_do.UseVisualStyleBackColor = false;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(229, 280);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(439, 22);
            this.output.TabIndex = 10;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(229, 354);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(593, 354);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Lab1_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.HeMuonDoi);
            this.Controls.Add(this.HeHienTai);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "Lab1_Bai04";
            this.Text = "Lab1_Bai04 Convert HEC, DEC, BIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ComboBox HeHienTai;
        private System.Windows.Forms.ComboBox HeMuonDoi;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_exit;
    }
}