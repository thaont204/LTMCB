namespace Lab1_22521371_NguyenThanhThao
{
    partial class Lab1_Bai02
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
            this.Tim = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.so1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.so3 = new System.Windows.Forms.Label();
            this.solon = new System.Windows.Forms.Label();
            this.sonho = new System.Windows.Forms.Label();
            this.outmax = new System.Windows.Forms.TextBox();
            this.outmin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tim
            // 
            this.Tim.Location = new System.Drawing.Point(120, 192);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(75, 23);
            this.Tim.TabIndex = 0;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(350, 192);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 1;
            this.del.Text = "Xóa";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(606, 192);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(118, 60);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 22);
            this.input1.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(368, 63);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 22);
            this.input2.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(655, 63);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 22);
            this.input3.TabIndex = 5;
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Location = new System.Drawing.Point(12, 66);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(81, 16);
            this.so1.TabIndex = 6;
            this.so1.Text = "Số Thứ Nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Thứ Hai";
            // 
            // so3
            // 
            this.so3.AutoSize = true;
            this.so3.Location = new System.Drawing.Point(561, 69);
            this.so3.Name = "so3";
            this.so3.Size = new System.Drawing.Size(70, 16);
            this.so3.TabIndex = 8;
            this.so3.Text = "Số Thứ Ba";
            // 
            // solon
            // 
            this.solon.AutoSize = true;
            this.solon.Location = new System.Drawing.Point(115, 331);
            this.solon.Name = "solon";
            this.solon.Size = new System.Drawing.Size(80, 16);
            this.solon.TabIndex = 9;
            this.solon.Text = "Số Lớn Nhất";
            // 
            // sonho
            // 
            this.sonho.AutoSize = true;
            this.sonho.Location = new System.Drawing.Point(486, 331);
            this.sonho.Name = "sonho";
            this.sonho.Size = new System.Drawing.Size(83, 16);
            this.sonho.TabIndex = 10;
            this.sonho.Text = "Số Nhỏ Nhất";
            // 
            // outmax
            // 
            this.outmax.Enabled = false;
            this.outmax.Location = new System.Drawing.Point(232, 325);
            this.outmax.Name = "outmax";
            this.outmax.Size = new System.Drawing.Size(100, 22);
            this.outmax.TabIndex = 11;
            // 
            // outmin
            // 
            this.outmin.Enabled = false;
            this.outmin.Location = new System.Drawing.Point(606, 325);
            this.outmin.Name = "outmin";
            this.outmin.Size = new System.Drawing.Size(121, 22);
            this.outmin.TabIndex = 12;
            // 
            // Lab1_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outmin);
            this.Controls.Add(this.outmax);
            this.Controls.Add(this.sonho);
            this.Controls.Add(this.solon);
            this.Controls.Add(this.so3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.del);
            this.Controls.Add(this.Tim);
            this.Name = "Lab1_Bai02";
            this.Text = "Lab1_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label so3;
        private System.Windows.Forms.Label solon;
        private System.Windows.Forms.Label sonho;
        private System.Windows.Forms.TextBox outmax;
        private System.Windows.Forms.TextBox outmin;
    }
}