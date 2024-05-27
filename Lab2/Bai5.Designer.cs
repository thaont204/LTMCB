namespace Lab2
{
    partial class Bai5
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
            Files_list = new ListView();
            FileName = new ColumnHeader();
            FileSize = new ColumnHeader();
            FileExten = new ColumnHeader();
            FileTime = new ColumnHeader();
            SuspendLayout();
            // 
            // Files_list
            // 
            Files_list.Columns.AddRange(new ColumnHeader[] { FileName, FileSize, FileExten, FileTime });
            Files_list.Location = new Point(1, 1);
            Files_list.Name = "Files_list";
            Files_list.Size = new Size(800, 446);
            Files_list.TabIndex = 0;
            Files_list.UseCompatibleStateImageBehavior = false;
            Files_list.View = View.Details;
            // 
            // FileName
            // 
            FileName.Text = "Tên file";
            FileName.Width = 300;
            // 
            // FileSize
            // 
            FileSize.Text = "Kích thước";
            FileSize.Width = 150;
            // 
            // FileExten
            // 
            FileExten.Text = "Đuôi mở rộng";
            FileExten.Width = 150;
            // 
            // FileTime
            // 
            FileTime.Text = "Ngày tạo";
            FileTime.Width = 250;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Files_list);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
        }

        #endregion

        private ListView Files_list;
        private ColumnHeader FileName;
        private ColumnHeader FileSize;
        private ColumnHeader FileExten;
        private ColumnHeader FileTime;
    }
}