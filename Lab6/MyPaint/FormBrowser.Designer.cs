using System.Drawing;
using System.Windows.Forms;
using System;

namespace MyPaint
{
    partial class FormBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBar = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchBar.FormattingEnabled = true;
            this.SearchBar.Location = new System.Drawing.Point(125, 4);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(398, 36);
            this.SearchBar.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_btn.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Italic);
            this.Search_btn.Location = new System.Drawing.Point(663, 4);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(125, 30);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "GO!";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 38);
            this.webView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(800, 322);
            this.webView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView.TabIndex = 2;
            this.webView.ZoomFactor = 1D;
            // 
            // Previous_btn
            // 
            this.Previous_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Previous_btn.Location = new System.Drawing.Point(0, 4);
            this.Previous_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(57, 30);
            this.Previous_btn.TabIndex = 5;
            this.Previous_btn.Text = "<";
            this.Previous_btn.UseVisualStyleBackColor = true;
            // 
            // Next_btn
            // 
            this.Next_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Next_btn.Location = new System.Drawing.Point(62, 4);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(57, 30);
            this.Next_btn.TabIndex = 6;
            this.Next_btn.Text = ">";
            this.Next_btn.UseVisualStyleBackColor = true;
            // 
            // FormBrowser
            // 
            this.AcceptButton = this.Search_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Previous_btn);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBrowser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox SearchBar;
        private Button Search_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button Previous_btn;
        private Button Next_btn;
    }
}