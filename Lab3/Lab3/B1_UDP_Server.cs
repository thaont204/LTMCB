using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B1_UDP_Server : Form
    {
        public B1_UDP_Server()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            int port = Convert.ToInt32(tb_Port.Text);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);
                Byte[] recvBytes = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(recvBytes);
                string mess = IpEnd.Address.ToString() + ": " + Data.ToString();
                InfoMess(mess);
            }
        }

        public void InfoMess(string m)
        {
            if (list_Mess.InvokeRequired)
            {
                list_Mess.Invoke((MethodInvoker)delegate
                {
                    list_Mess.Items.Add(m);
                });
            }
            else
            {
                    list_Mess.Items.Add(m);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            Task.Run(() => serverThread());
        }
    }
}
