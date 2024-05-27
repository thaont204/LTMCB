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
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }
    }
}
