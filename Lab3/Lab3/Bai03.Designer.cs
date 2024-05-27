namespace Lab3
{
    partial class Bai03
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
            this.Server_btn = new System.Windows.Forms.Button();
            this.Client_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server_btn
            // 
            this.Server_btn.Location = new System.Drawing.Point(194, 87);
            this.Server_btn.Name = "Server_btn";
            this.Server_btn.Size = new System.Drawing.Size(427, 61);
            this.Server_btn.TabIndex = 0;
            this.Server_btn.Text = "Open TCP Server";
            this.Server_btn.UseVisualStyleBackColor = true;
            this.Server_btn.Click += new System.EventHandler(this.Server_btn_Click);
            // 
            // Client_btn
            // 
            this.Client_btn.Location = new System.Drawing.Point(194, 210);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.Size = new System.Drawing.Size(427, 61);
            this.Client_btn.TabIndex = 1;
            this.Client_btn.Text = "Open new TCP client";
            this.Client_btn.UseVisualStyleBackColor = true;
            this.Client_btn.Click += new System.EventHandler(this.Client_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(194, 324);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(427, 61);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Client_btn);
            this.Controls.Add(this.Server_btn);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Server_btn;
        private System.Windows.Forms.Button Client_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}