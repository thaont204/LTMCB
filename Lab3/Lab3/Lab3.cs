using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai01 bai01 = new Bai01();
            bai01.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai02 bai02 = new Bai02();
            bai02.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai03 bai03 = new Bai03();
            bai03.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 bai04 = new Bai04();
            bai04.Show();
        }
    }
}
