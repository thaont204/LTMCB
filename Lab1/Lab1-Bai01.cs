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
    public partial class Lab1_Bai01 : Form
    {
        public Lab1_Bai01()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            bool sucess1 = int.TryParse(input1.Text.Trim(), out num1);
            bool sucess2 = int.TryParse(input2.Text.Trim(), out num2);
            if (!sucess1 || !sucess2)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
            else
            {
                sum = num1 + num2;
                output.Text = sum.ToString();
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            input1.Text = string.Empty;
            input2.Text = string.Empty;
            output.Text = string.Empty;
        }
    }
}
