using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_btn_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void Bai2_btn_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void Bai3_btn_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void Bai4_btn_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();    
        }
    }
}
