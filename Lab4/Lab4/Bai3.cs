using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            string url = URL_tb.Text;
            string path = Path_tb.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                URL_tb.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            if (Directory.Exists(path))
            {
                Path_tb.Focus();
                MessageBox.Show("Đường dẫn không đúng định dạng");
                return;
            }

            WebClient myClient = new WebClient();
            Stream dataStream = myClient.OpenRead(url);
            StreamReader reader = new StreamReader(dataStream);

            Content_rtb.Text = reader.ReadToEnd();
            myClient.DownloadFile(url, path);
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            Path_tb.Text = Directory.GetCurrentDirectory() + "\\index.html";
        }
    }
}
