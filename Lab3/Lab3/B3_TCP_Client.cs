using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B3_TCP_Client : Form
    {
        public B3_TCP_Client()
        {
            InitializeComponent();
        }

        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        TcpClient tcpClient = new TcpClient();
        bool isConnected = false;
        NetworkStream ns;

        private void Send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    tcpClient.Connect(ipEndPoint);
                    ns = tcpClient.GetStream();
                    isConnected = true;
                }

                byte[] data = Encoding.ASCII.GetBytes("Hello server\n");
                ns.Write(data, 0, data.Length);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void B3_TCP_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Byte[] dataa = System.Text.Encoding.ASCII.GetBytes("quit \n");
            ns.Write(dataa, 0, dataa.Length);

            tcpClient.Close();
            if (ns != null) ns.Close();
        }
    }
}
