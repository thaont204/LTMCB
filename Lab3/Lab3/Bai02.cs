﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket clientSocket;
            Socket listenSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            listenSocket.Bind(ipepServer);
            listenSocket.Listen(-1);
            clientSocket = listenSocket.Accept();
            Mess_lv.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length-1] != '\n');
                if (!string.IsNullOrWhiteSpace(text))
                    Mess_lv.Items.Add(text);
            }
            clientSocket.Close();
        }

        bool isListening = false;
        private void Listen_btn_Click(object sender, EventArgs e)
        {
            if (isListening) return;
            isListening = true;
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            Mess_lv.Items.Add("Telnet is running on" + ipepServer.ToString());

            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab3 lab3 = new Lab3();
            lab3.Show();
        }
    }
}
