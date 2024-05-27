using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            B1_UDP_Server server = new B1_UDP_Server();
            server.Show();
        }

        public void btn_Client_Click(object sender, EventArgs e)
        {
            B1_UDP_Client client = new B1_UDP_Client();
            client.Show();
            Thread th = new Thread(Run);
            th.IsBackground = true;
            th.Start();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab3 lab3 = new Lab3();
            lab3.Show();
        }

        void Run()
        {
            Bai01 bai1 = new Bai01();
            bai1.Show();
        }
    }
}
