namespace Lab2
{
    partial class Bai3
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
            btn_Read = new Button();
            btn_Write = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rtb_Input = new RichTextBox();
            tabPage2 = new TabPage();
            rtb_Output = new RichTextBox();
            btn_Exit = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(43, 60);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(129, 53);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "Đọc file";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(43, 170);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(129, 57);
            btn_Write.TabIndex = 1;
            btn_Write.Text = "Ghi file";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(239, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(536, 325);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rtb_Input);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(528, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Input";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb_Input
            // 
            rtb_Input.Location = new Point(0, 0);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(528, 292);
            rtb_Input.TabIndex = 0;
            rtb_Input.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rtb_Output);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(528, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Output";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtb_Output
            // 
            rtb_Output.Location = new Point(0, 0);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.Size = new Size(528, 292);
            rtb_Output.TabIndex = 0;
            rtb_Output.Text = "";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(43, 282);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(129, 55);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(tabControl1);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Name = "Bai3";
            Text = "Bai3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Read;
        private Button btn_Write;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox rtb_Input;
        private RichTextBox rtb_Output;
        private Button btn_Exit;
    }
}