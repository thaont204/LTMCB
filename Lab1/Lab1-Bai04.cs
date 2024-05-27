using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_22521371_NguyenThanhThao
{
    public partial class Lab1_Bai04 : Form
    {
        public Lab1_Bai04()
        {
            InitializeComponent();
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            try
            {
                int fromBase = 10;
                int toBase = 10;

                if (HeHienTai.Text == "HEX")
                {
                    fromBase = 16;
                }
                else if (HeHienTai.Text == "DEC")
                {
                    fromBase = 10;
                }
                else if (HeHienTai.Text == "BIN")
                {
                    fromBase = 2;
                }
                if (HeMuonDoi.Text == "HEX")
                {
                    toBase = 16;

                }
                else if (HeMuonDoi.Text == "DEC")
                {
                    toBase = 10;
                }
                else if (HeMuonDoi.Text == "BIN")
                {
                    toBase = 2;
                }
                output.Text = Convert.ToString(Convert.ToInt32(input.Text, fromBase), toBase);
            }
            catch
            {
                MessageBox.Show("Error: Khong hop le");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
        }
    }
}
