using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Lab3
{
    public partial class B1_UDP_Client : Form
    {
        public B1_UDP_Client()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();

            IPAddress ipadd = IPAddress.Parse(tb_IP.Text);
            int port = Convert.ToInt32(tb_Port.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);

            Byte[] sendBytes = Encoding.UTF8.GetBytes(rtb_Mess.Text);
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
        }
    }
}
