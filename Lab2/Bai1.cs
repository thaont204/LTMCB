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
    public partial class Bai1 : Form
    {
        public Bai1()
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
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    string content = output.Text.ToUpper();
                    sr.WriteLine(content);
                }
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
