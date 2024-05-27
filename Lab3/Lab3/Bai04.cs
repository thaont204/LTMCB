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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Server_btn_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["B4_TCP_Server"];

            if (frm != null)
                frm.BringToFront();
            else
            {
                frm = new B4_TCP_Server();
                frm.Show();
            }
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
                B4_TCP_Client frm = new B4_TCP_Client();
                frm.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab3 lab3 = new Lab3();
            lab3.Show();
        }
    }
}
