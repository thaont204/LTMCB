using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                output.Text = content;

                filename.Text = ofd.SafeFileName.ToString();

                Url.Text = fs.Name.ToString();

                numchar.Text = content.Length.ToString();

                content = content.Replace("\r\n", "\r");
                numline.Text = output.Lines.Count().ToString();
                content = content.Replace("\r", "\r\n");

                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                numword.Text = source.Count().ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2 lab2 = new Lab2();
            lab2.Show();
        }
    }
}
