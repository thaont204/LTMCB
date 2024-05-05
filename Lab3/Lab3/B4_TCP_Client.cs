﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B4_TCP_Client : Form
    {
        int port = 8080;
        string address = "127.0.0.1";
        IPEndPoint server;
        TcpClient client = new TcpClient();
        NetworkStream stream;

        private async void ListenToServer()
        {
            while (client.Connected)
            {
                string mess = "";
                byte[] data = new byte[4096];
                try
                {
                    await stream.ReadAsync(data, 0, data.Length);
                    mess = Encoding.UTF8.GetString(data);
                    Chat_box.Text += mess + "\n";
                    Chat_box.SelectionStart = Chat_box.Text.Length;
                    Chat_box.ScrollToCaret();
                }
                catch
                {
                    MessageBox.Show("Lỗi listening to server!!");
                }
            }
        }


        public B4_TCP_Client()
        {
            InitializeComponent();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if(!client.Connected)
            {
                CheckForIllegalCrossThreadCalls = false;

                server = new IPEndPoint(IPAddress.Parse(address), port);
                try
                {
                    client.Connect(server);
                }
                catch
                {
                    MessageBox.Show("Chua mo server");
                    return;
                }
                if (client.Connected)
                {
                    stream = client.GetStream();
                    Thread listen = new Thread(ListenToServer); listen.Start();
                }
            }


            if (Name_box.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Chua dien ten");
                return;
            }

            string mess = $"{Name_box.Text}: {Mess_box.Text} \n";
            byte[] buffer = Encoding.UTF8.GetBytes(mess);
            stream.WriteAsync(buffer, 0, buffer.Length);
            Mess_box.Text = String.Empty;
        }

        private void B4_TCP_Client_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Chat_box.ReadOnly = true;

            server = new IPEndPoint(IPAddress.Parse(address), port);
            try
            {
                client.Connect(server);
            }
            catch
            {
                MessageBox.Show("Chua mo server");
            }
            if (client.Connected)
            {
                stream = client.GetStream();
                Thread listen = new Thread(ListenToServer); listen.Start();
            }
        }
    }
}