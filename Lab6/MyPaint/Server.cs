using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class frm_Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clientList;
        private int maxClients = 5; // Maximum number of clients allowed

        public frm_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            clientList = new List<TcpClient>();
            StartServer();
        }

        private async void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 9999);
                server.Start();

                await AcceptClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server: " + ex.Message);
            }
        }

        private async Task AcceptClients()
        {
            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();

                if (client.Connected)
                {
                    clientList.Add(client);
                    lbl_NumClients.Text = clientList.Count.ToString();
                    await Task.Run(() => { ReceiveAsync(client); });
                }
            }
        }

        private async void ReceiveAsync(TcpClient tcpClient)
        {
            try
            {
                NetworkStream stream = tcpClient.GetStream();
                byte[] buffer = new byte[4096*10];

                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                        throw new IOException(); // Connection closed gracefully by client

                    // Handle received data (e.g., broadcast to other clients)
                    await BroadcastAsync(buffer, tcpClient);
                }
            }
            catch (IOException)
            {
                // Handle client disconnect
                clientList.Remove(tcpClient);
                lbl_NumClients.Text = clientList.Count.ToString();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                LogError("Error receiving data: " + ex.Message);
            }
        }

        private void UpdateClientCount()
        {
            if (lbl_NumClients.InvokeRequired)
            {
                lbl_NumClients.Invoke((Action)(() => lbl_NumClients.Text = clientList.Count.ToString()));
            }
            else
            {
                lbl_NumClients.Text = clientList.Count.ToString();
            }
        }

        private async void btn_AddClient_Click(object sender, EventArgs e)
        {
            if (clientList.Count >= maxClients)
            {
                MessageBox.Show("Quá số lượng client cho phép!");
                return;
            }

            frm_Client frm = new frm_Client();
            await frm.Connect();
        }




        private void frm_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseServer();
        }

        private void CloseServer()
        {
            foreach (TcpClient client in clientList)
            {
                client.Close();
            }
            server.Stop();
        }

        // Serialization and deserialization methods
        public byte[] SerializeData(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public object DeserializeData(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(ms);
            }
        }
        private async Task BroadcastAsync(byte[] data, TcpClient senderClient)
        {
            foreach (TcpClient client in clientList)
            {

                if (client != senderClient)
                {
                    NetworkStream clientStream = client.GetStream();
                    await clientStream.WriteAsync(data, 0, data.Length); // Echo data to all clients except sender
                }
            }
        }

        // Other methods (UpdateClientCount, btn_AddClient_Click, frm_Server_FormClosing, CloseServer, SerializeData, DeserializeData) remain the same

        // Helper method for error logging
        private void LogError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, log to a file
            string logFilePath = "server_log.txt";
            File.AppendAllText(logFilePath, DateTime.Now.ToString() + ": " + errorMessage + Environment.NewLine);
        }

        private void frm_Server_Load(object sender, EventArgs e)
        {

        }
    }
}
