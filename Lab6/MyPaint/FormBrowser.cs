using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            SearchBar.Text = "https://google.com";
            this.Size = new System.Drawing.Size(1080, 720);

        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
        }
        private void FormBrowser_Load(object sender, EventArgs e)
        {
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string uri = SearchBar.Text;

            if (string.IsNullOrEmpty(uri))
            {
                uri.Equals("about:blank");
                return;
            }

            if (!uri.StartsWith("https://") && !uri.StartsWith("http://"))
            {
                uri = "http://" + uri;
            }

            try
            {
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(SearchBar.Text);
                    MessageBox.Show(SearchBar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
