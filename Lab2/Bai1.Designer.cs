namespace Lab2
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
            btn_read = new Button();
            btn_write = new Button();
            output = new RichTextBox();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.Location = new Point(102, 109);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(197, 59);
            btn_read.TabIndex = 0;
            btn_read.Text = "ĐỌC FILE";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_write
            // 
            btn_write.Location = new Point(102, 213);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(197, 57);
            btn_write.TabIndex = 1;
            btn_write.Text = "GHI FILE";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // output
            // 
            output.Location = new Point(379, 109);
            output.Name = "output";
            output.Size = new Size(388, 265);
            output.TabIndex = 2;
            output.Text = "";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(102, 324);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(197, 50);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "THOÁT";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(output);
            Controls.Add(btn_write);
            Controls.Add(btn_read);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_read;
        private Button btn_write;
        private RichTextBox output;
        private Button btn_exit;
    }
}