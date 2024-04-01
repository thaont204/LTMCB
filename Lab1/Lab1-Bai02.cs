using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521371_NguyenThanhThao
{
    public partial class Lab1_Bai02 : Form
    {
        public Lab1_Bai02()
        {
            InitializeComponent();
        }

        private List<float> m_list = new List<float>();


        private void Tim_Click(object sender, EventArgs e)
        {
            m_list.Clear();
            float num1, num2, num3;
            try
            {
                num1 = float.Parse(input1.Text.Trim());
                num2 = float.Parse(input2.Text.Trim());
                num3 = float.Parse(input3.Text.Trim());
                m_list.Add(num1);
                m_list.Add(num2);
                m_list.Add(num3);

                outmin.Text = m_list.Min().ToString();
                outmax.Text = m_list.Max().ToString();
            }
            catch
            {
                MessageBox.Show("Nhập lại số");
            }

        }

        private void del_Click(object sender, EventArgs e)
        {
            outmin.Text = string.Empty;
            outmax.Text = string.Empty;
            input1.Text = string.Empty;
            input2.Text = string.Empty;
            input3.Text = string.Empty;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }
    }
}
