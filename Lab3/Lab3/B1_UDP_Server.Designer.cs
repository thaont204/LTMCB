namespace Lab3
{
    partial class B1_UDP_Server
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
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.list_Mess = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Received messages";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(153, 52);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(126, 22);
            this.tb_Port.TabIndex = 2;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(580, 42);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(116, 42);
            this.btn_Listen.TabIndex = 4;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // list_Mess
            // 
            this.list_Mess.HideSelection = false;
            this.list_Mess.Location = new System.Drawing.Point(63, 158);
            this.list_Mess.Name = "list_Mess";
            this.list_Mess.Size = new System.Drawing.Size(633, 253);
            this.list_Mess.TabIndex = 5;
            this.list_Mess.UseCompatibleStateImageBehavior = false;
            this.list_Mess.View = System.Windows.Forms.View.List;
            // 
            // B1_UDP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_Mess);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "B1_UDP_Server";
            this.Text = "B1_UDP_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListView list_Mess;
    }
}