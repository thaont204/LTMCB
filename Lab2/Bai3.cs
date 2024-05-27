using System;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private string filePath;
        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            filePath = Path.GetDirectoryName(ofd.FileName);

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtb_Input.Text = content;
            fs.Close();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtb_Input.Text))
            {
                MessageBox.Show("Không có gì để ghi !!!");
                return;
            }

            try
            {
                string fileName = Path.Combine(filePath, "output.txt");
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    DataTable dt = new DataTable();

                    for (int i = 0; i < rtb_Input.Lines.Length; i++)
                    {
                        string expression = rtb_Input.Lines[i];
                        string result = dt.Compute(expression, "").ToString();
                        rtb_Output.AppendText(expression + " = " + result + "\n");
                    }

                    sw.WriteLine(rtb_Output.Text);
                    MessageBox.Show("Ghi thành công !!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2 lab = new Lab2();
            lab.Show();
        }
    }
}
