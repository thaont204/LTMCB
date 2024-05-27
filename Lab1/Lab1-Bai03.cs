using System;
using System.Collections;
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
    public partial class Lab1_Bai03 : Form
    {
        public Lab1_Bai03()
        {
            InitializeComponent();
        }

        private string[] Donvi = { "không", "một", "hai", "ba","bốn","năm","sáu","bảy","tám","chín", "mười"};
        
        private string Doc(int num)
        {
            string tenso = string.Empty;

            if (num > 0)
            {
                if(num <= 10)
                {
                    tenso = Donvi[num].ToString();
                    return tenso;
                }
                else if (num < 100)
                {
                    int hang_dv = num % 10;
                    int hang_chuc = num / 10;

                    if (hang_chuc == 1)
                    {
                        if (hang_dv == 5)
                            return "mười lăm";
                        else
                        {
                            return "mười " + Doc(hang_dv);
                        }
                    }
                    else
                    {
                        if (hang_dv == 5)
                        {
                            tenso = Donvi[hang_chuc].ToString() + " mươi lăm";
                            return tenso;
                        }
                        else
                        {
                            tenso = Donvi[hang_chuc].ToString() + " mươi " + Doc(hang_dv);
                            return tenso;
                        }
                    }
                }
                else if (num < 1000)
                {
                    int so_du = num % 100;
                    int hang_tram = num / 100;
                    tenso = Donvi[hang_tram].ToString() + " trăm " + Doc(so_du);
                    return tenso;
                }
                else if(num < 1000000)
                {
                    int so_du = num % 1000;
                    int hang_ngan = num / 1000;
                    tenso = Doc(hang_ngan) + " nghìn " + Doc(so_du);
                    return tenso;
                }

            }
            if (num < 0)
            {
                tenso = "âm " + Doc(-1*num);
            }
            return tenso;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            output.Text = Doc(Int32.Parse(input.Text));
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;
            output.Text = string.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }
    }
}
