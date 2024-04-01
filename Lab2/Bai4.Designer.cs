namespace Lab2
{
    partial class Bai4
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
            Write_Input_btn = new Button();
            ReadButton = new Button();
            WriteButton = new Button();
            Exit_btn = new Button();
            Data = new RichTextBox();
            SuspendLayout();
            // 
            // Write_Input_btn
            // 
            Write_Input_btn.Location = new Point(72, 12);
            Write_Input_btn.Name = "Write_Input_btn";
            Write_Input_btn.Size = new Size(130, 50);
            Write_Input_btn.TabIndex = 0;
            Write_Input_btn.Text = "Ghi xuống input.txt";
            Write_Input_btn.UseVisualStyleBackColor = true;
            Write_Input_btn.Click += Write_Input_btn_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(72, 114);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(130, 48);
            ReadButton.TabIndex = 1;
            ReadButton.Text = "Đọc input.txt";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(72, 214);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(130, 51);
            WriteButton.TabIndex = 2;
            WriteButton.Text = "Xuất output.txt";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(72, 325);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(130, 55);
            Exit_btn.TabIndex = 3;
            Exit_btn.Text = "Thoát";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Data
            // 
            Data.Location = new Point(298, 12);
            Data.Name = "Data";
            Data.Size = new Size(490, 426);
            Data.TabIndex = 4;
            Data.Text = "";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Data);
            Controls.Add(Exit_btn);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(Write_Input_btn);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
        }

        #endregion

        private Button Write_Input_btn;
        private Button ReadButton;
        private Button WriteButton;
        private Button Exit_btn;
        private RichTextBox Data;
    }
}