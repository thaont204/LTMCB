using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521371_NguyenThanhThao
{
    public partial class Lab1_Bai05 : Form
    {
        public Lab1_Bai05()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string[] s = inputDiem.Text.Split(' ');

            int n = 0;
            float[] score = new float[s.Length];

            Label[] la = { lbm1, lbm2, lbm3, lbm4, lbm5, lbm6, lbm7, lbm8, lbm9, lbm10, lbm11, lbm12 };

            //Kiểm tra tính hợp lệ
            foreach (string splitted in s) 
            {
                float num;
                bool success = float.TryParse(splitted, out num);
                if (success && num >= 0 && num <= 10)
                {
                    score[n++] = num;
                }
                else
                {
                    MessageBox.Show("Đã nhập sai format");
                    inputDiem.Clear();
                    DiemTB.Text = "Điểm trung bình: ";
                    maxscore.Text = "Môn có điểm cao nhất: ";
                    minscore.Text = "Môn có điểm thấp nhất: ";
                    numDau.Text = "Số môn đậu: ";
                    numKodau.Text = "Số môn không đậu: ";
                    XL.Text = "Xếp loại học lực: ";
                    lbm1.Text = "Môn 1: ";
                    lbm2.Text = "Môn 2: ";
                    lbm3.Text = "Môn 3: ";
                    lbm4.Text = "Môn 4: ";
                    lbm5.Text = "Môn 5: ";
                    lbm6.Text = "Môn 6: ";
                    lbm7.Text = "Môn 7: ";
                    lbm8.Text = "Môn 8: ";
                    lbm9.Text = "Môn 9: ";
                    lbm10.Text = "Môn 10: ";
                    lbm11.Text = "Môn 11: ";
                    lbm12.Text = "Môn 12: ";
                    break;
                }
            }

            if (n == s.Length)
            {
                MessageBox.Show("Đã nhập đúng format");

                //Danh sách điểm
                for (int i = 0; i < n; i++)
                    la[i].Text += score[i].ToString() + "đ";

                float dtb = 0;
                float max = -1, min = 100;
                int d = 0, kd = 0;

                for (int i = 0; i < n; i++)
                {
                    dtb += score[i];

                    //Tìm điểm cao nhất, điểm thấp nhất
                    if (max < score[i]) { max = score[i]; }
                    if (min > score[i]) { min = score[i]; }

                    //Tính số môn đậu, số môn không đậu
                    if (score[i] < 5)
                    {
                        kd++;
                    }
                    else
                    {
                        d++;
                    }
                }

                //Tính điểm trung bình
                dtb = dtb / n;

                //Xếp loại
                if (dtb >= 8 && min >= 6.5)
                {
                    XL.Text += "Giỏi"; 
                }
                else if (dtb >= 6.5 && min >=5)
                {
                    XL.Text += "Khá";
                }
                else if (dtb >= 5 && min >= 3.5)
                {
                    XL.Text += "TB";
                }
                else if (dtb >= 3.5 && min >= 2)
                {
                    XL.Text += "Yếu";
                }
                else
                {
                    XL.Text += "Kém";
                }

                //Xuất
                DiemTB.Text += dtb.ToString();

                maxscore.Text += max.ToString() + " đ";
                minscore.Text += min.ToString() + " đ";

                numDau.Text += d.ToString();
                numKodau.Text += kd.ToString();
            }
        }
    }
}
