using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1280, 920);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            Search_btn.Left = Source_btn.Right + 2;
            SearchBar.Width = Download_btn.Left - SearchBar.Left;
            Source_btn.Left = Download_btn.Right + 2;
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
                uri = "https://" + uri;
                SearchBar.Text = uri;
            }

            try
            {
                if (webView != null)
                {
                    webView.Navigate(SearchBar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(SearchBar.Text);
                myClient.DownloadFile(SearchBar.Text, $"{Directory.GetCurrentDirectory()}/Cache.txt");

                var web = new HtmlWeb();
                var document = new HtmlAgilityPack.HtmlDocument();
                document = web.Load(SearchBar.Text);
                FileStream sw = new FileStream("FileStream.html", FileMode.OpenOrCreate);

                document.Save(sw);
                MessageBox.Show("Downloaded successfully");
            }
            catch
            {
                MessageBox.Show("Download failed");

            }
        }

        private void Source_btn_Click(object sender, EventArgs e)
        {
            string htmlcontent = getHTML(SearchBar.Text);

            HTML_src new_form = new HTML_src(htmlcontent);
            new_form.Show();
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }


        private string getHTML(string szURL)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response.
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Close the response.
                response.Close();
                dataStream.Close();
                reader.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "Failed to load html!";
            }
        }
    }
}
