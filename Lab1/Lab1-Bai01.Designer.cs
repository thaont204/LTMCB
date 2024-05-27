namespace Lab1_22521371_NguyenThanhThao
{
    partial class Lab1_Bai01
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
            this.so1 = new System.Windows.Forms.Label();
            this.so2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Location = new System.Drawing.Point(51, 44);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(54, 16);
            this.so1.TabIndex = 0;
            this.so1.Text = "Số thứ 1";
            // 
            // so2
            // 
            this.so2.AutoSize = true;
            this.so2.Location = new System.Drawing.Point(51, 97);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(54, 16);
            this.so2.TabIndex = 1;
            this.so2.Text = "Số thứ 2";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(51, 153);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(52, 16);
            this.res.TabIndex = 2;
            this.res.Text = "Kết quả";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(212, 38);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 22);
            this.input1.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(212, 91);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 22);
            this.input2.TabIndex = 4;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(212, 147);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 22);
            this.output.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(129, 255);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 6;
            this.sum.Text = "Tính";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(363, 255);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 7;
            this.del.Text = "Xóa";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(617, 255);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Lab1_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 503);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.del);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Name = "Lab1_Bai01";
            this.Text = "Lab1_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label so2;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button exit;
    }
}