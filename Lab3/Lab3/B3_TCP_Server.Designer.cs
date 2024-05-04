namespace Lab3
{
    partial class B3_TCP_Server
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
            this.Mess_lv = new System.Windows.Forms.ListView();
            this.Listen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mess_lv
            // 
            this.Mess_lv.HideSelection = false;
            this.Mess_lv.Location = new System.Drawing.Point(63, 78);
            this.Mess_lv.Name = "Mess_lv";
            this.Mess_lv.Size = new System.Drawing.Size(676, 360);
            this.Mess_lv.TabIndex = 2;
            this.Mess_lv.UseCompatibleStateImageBehavior = false;
            this.Mess_lv.View = System.Windows.Forms.View.List;
            // 
            // Listen_btn
            // 
            this.Listen_btn.Location = new System.Drawing.Point(620, 33);
            this.Listen_btn.Name = "Listen_btn";
            this.Listen_btn.Size = new System.Drawing.Size(119, 39);
            this.Listen_btn.TabIndex = 3;
            this.Listen_btn.Text = "Listen";
            this.Listen_btn.UseVisualStyleBackColor = true;
            this.Listen_btn.Click += new System.EventHandler(this.Listen_btn_Click);
            // 
            // B3_TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listen_btn);
            this.Controls.Add(this.Mess_lv);
            this.Name = "B3_TCP_Server";
            this.Text = "B3_TCP_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Mess_lv;
        private System.Windows.Forms.Button Listen_btn;
    }
}