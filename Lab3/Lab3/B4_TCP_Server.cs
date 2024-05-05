using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B4_TCP_Server : Form
    {
        int port = 8080;

        TcpListener listener;
        NetworkStream stream;
        List<TcpClient> clients = new List<TcpClient>();

        delegate void SetTextCallback(string text);
        private void AddText(string text)
        {
            if (this.ServerLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.ServerLog.Text += text;
                ServerLog.SelectionStart = ServerLog.Text.Length;
                ServerLog.ScrollToCaret();
            }
        }

        public B4_TCP_Server()
        {
            InitializeComponent();
        }
        private async void HandleClient(TcpClient this_client)
        {
            try
            {
                stream = this_client.GetStream();
                while (this_client.Connected)
                {
                    byte[] buffer = new byte[1024];
                    await stream.ReadAsync(buffer, 0, buffer.Length);
                    string mess = $"{this_client.Client.RemoteEndPoint}: {Encoding.UTF8.GetString(buffer)}";
                    AddText(mess);

                    //Broadcast cho may thang khac
                    foreach (TcpClient client in clients)
                    {
                        await client.GetStream().WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }
            catch
            {

                AddText("Lỗi xử lý client");

            }
            finally
            {
                AddText("A client disconected\n");
                clients.Remove(this_client);
                this_client.Close();
            }
        }
        private async void Listen_btn_Click(object sender, EventArgs e)
        {
            ServerLog.Text = "";
            ServerLog.ReadOnly = true;
            Listen_btn.Enabled = false;
            Listen_btn.BackColor = Color.LightGreen;
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            ServerLog.Text += $"Server started on {port}\n";

            while (true)
            {
                TcpClient new_client = await listener.AcceptTcpClientAsync();
                ServerLog.Text += $"New client connected from {new_client.Client.RemoteEndPoint}\n";
                clients.Add(new_client);
                Thread newthread = new Thread(() =>
                {
                    HandleClient(new_client);
                });

                newthread.Start();

            }
        }
    }
}
