using Newtonsoft.Json.Linq;
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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Post_btn_Click(object sender, EventArgs e)
        {
            string url = URL_tb.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                URL_tb.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(Data_tb.Text);
                WebRequest request = WebRequest.Create(url);

                request.Method = "POST";
                request.ContentType = "text/plain";
                request.ContentLength = byteArray.Length;

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        string responseText = reader.ReadToEnd();

                        if (response.ContentType.Contains("application/json"))
                        {
                            Content_rtb.Text = JToken.Parse(responseText).ToString();
                        }
                        else
                        {
                            Content_rtb.Text = responseText;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
