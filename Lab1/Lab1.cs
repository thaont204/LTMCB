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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }
        
        private void Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai01 b1 = new Lab1_Bai01();
            b1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai02 b2 = new Lab1_Bai02();
            b2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai03 b3 = new Lab1_Bai03();
            b3.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai05 b5 = new Lab1_Bai05();
            b5.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai04 b4 = new Lab1_Bai04();
            b4.Show();
        }
    }
}
