namespace Lab2
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
            btn_read = new Button();
            output = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            filename = new TextBox();
            numline = new TextBox();
            numword = new TextBox();
            numchar = new TextBox();
            btn_exit = new Button();
            Url = new TextBox();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.Location = new Point(72, 27);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(229, 58);
            btn_read.TabIndex = 0;
            btn_read.Text = "ĐỌC FILE";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // output
            // 
            output.Location = new Point(387, 27);
            output.Name = "output";
            output.Size = new Size(401, 396);
            output.TabIndex = 1;
            output.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 3;
            label2.Text = "Url";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Số dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 278);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 329);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 6;
            label5.Text = "Số ký tự";
            // 
            // filename
            // 
            filename.Enabled = false;
            filename.Location = new Point(85, 103);
            filename.Name = "filename";
            filename.Size = new Size(276, 27);
            filename.TabIndex = 7;
            // 
            // numline
            // 
            numline.Enabled = false;
            numline.Location = new Point(85, 216);
            numline.Name = "numline";
            numline.Size = new Size(276, 27);
            numline.TabIndex = 9;
            // 
            // numword
            // 
            numword.Enabled = false;
            numword.Location = new Point(85, 271);
            numword.Name = "numword";
            numword.Size = new Size(276, 27);
            numword.TabIndex = 10;
            // 
            // numchar
            // 
            numchar.Enabled = false;
            numchar.Location = new Point(85, 322);
            numchar.Name = "numchar";
            numchar.Size = new Size(276, 27);
            numchar.TabIndex = 11;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(254, 394);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Url
            // 
            Url.Location = new Point(85, 158);
            Url.Name = "Url";
            Url.ReadOnly = true;
            Url.Size = new Size(276, 27);
            Url.TabIndex = 13;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Url);
            Controls.Add(btn_exit);
            Controls.Add(numchar);
            Controls.Add(numword);
            Controls.Add(numline);
            Controls.Add(filename);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(btn_read);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private RichTextBox output;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox filename;
        private TextBox numline;
        private TextBox numword;
        private TextBox numchar;
        private Button btn_exit;
        private TextBox Url;
    }
}