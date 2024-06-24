using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;

public enum DataType
{
    DrawingData = 1,
    ImageData = 2
}

namespace MyPaint
{
    public partial class frm_Client : Form
    {
        Point currentPos = new Point();
        Point oldPos = new Point();

        Pen pen = new Pen(Color.Red, 5);
        Pen eraser = new Pen(Color.White, 5);

        Graphics graph;
        Bitmap surface;
        TcpClient client;

        string fileName = "Picture";
        int index = 0;
        int width;
        private PictureBox pictureBox;
        private bool isDragging = false;
        private bool isResizing = false;
        private Point lastMousePosition;
        public frm_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            surface = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(surface);
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;

            pen.SetLineCap(
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.DashCap.Round
            );

            eraser.SetLineCap(
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.DashCap.Round
            );
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPos = e.Location;
            if (radioButton1.Checked) width = 5;
            else if (radioButton2.Checked) width = 10;
            else if (radioButton3.Checked) width = 15;
            else if (radioButton4.Checked) width = 20;
            else if (radioButton5.Checked) width = 25;

            pen.Width = width;
            eraser.Width = width;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                currentPos = e.Location;
                graph.DrawLine(pen, oldPos, currentPos);

                SocketData data = new SocketData(pen.Color, width, oldPos, currentPos);
                Send(data);

                oldPos = currentPos;
                panel1.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                currentPos = e.Location;
                graph.DrawLine(eraser, oldPos, currentPos);

                SocketData data = new SocketData(eraser.Color, width, oldPos, currentPos);
                Send(data);

                oldPos = currentPos;
                panel1.Invalidate();
            }
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                pen.Color = cd.Color;
        }

        private void btn_END_Click(object sender, EventArgs e)
        {
            index++;
            fileName = "Picture " + index + ".png";
            surface.Save(fileName, ImageFormat.Png);
            Close();
            this.Hide();
        }

        private void btn_Picture_Click(object sender, EventArgs e)
        {
            FormBrowser fb = new FormBrowser();
            fb.Show();
        }
        private void frm_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        public async Task Connect()
        {

            try 
            {
                client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 9999);
                if (client.Connected)
                {
                    await Task.Run(() => { Receive(); });
                    this.Show();
                }
                
            }
            catch (Exception err) 
            { 
                MessageBox.Show(err.Message);
            }

        }


        private void Send(SocketData drawingData)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    Console.WriteLine("Client is not connected.");
                    return;
                }

                NetworkStream stream = client.GetStream();

                // Serialize drawingData to byte array
                byte[] data = SerializeData(drawingData);
                Packet packet = new Packet();
                packet.Write((int)DataType.DrawingData);
                packet.Write(data);
                packet.WriteLength();

                // Send the actual data
                stream.WriteAsync(packet.ToArray(), 0, packet.Length());
                packet.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending drawing data: " + ex.Message);
                // Handle the error as needed (e.g., log, close connection)
            }
        }


        private async void SendPicture(System.Drawing.Image img)
        {
            if (client == null) return;

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                byte[] imgBytes = ms.ToArray();

                Packet packet = new Packet();
                packet.Write((int)DataType.ImageData);
                packet.Write(imgBytes);
                packet.WriteLength();

                await client.GetStream().WriteAsync(packet.ToArray(), 0, packet.Length());
                packet.Dispose();
            }
        }



        private async void Receive()
        {
            NetworkStream stream = client.GetStream();
            
            while (true)
            {
                byte[] data = new byte[4096*10];
                await stream.ReadAsync(data, 0, data.Length);
                try
                {
                    Packet packet = new Packet(data);
                    int len = packet.ReadInt();
                    DataType dataType = (DataType)packet.ReadInt();

                    if (dataType == DataType.DrawingData)
                    {
                        byte[] receivedData = packet.ReadBytes(24); // Subtract header
                        SocketData drawingData = (SocketData)DeserializeDrawingData(receivedData);
                        graph.DrawLine(new Pen(drawingData.PenColor, drawingData.Width), drawingData.OldPos, drawingData.CurrentPos);
                        panel1.Invalidate();
                    }
                    else if (dataType == DataType.ImageData)
                    {
                        byte[] receivedData = packet.ReadBytes(len - 4); // Subtract header 

                        using (MemoryStream ms = new MemoryStream(receivedData))
                        {
                            PictureBox pictureBox = new PictureBox()
                            {
                                Image = Image.FromStream(ms),
                                SizeMode = PictureBoxSizeMode.AutoSize,
                            };
                            pictureBox.MouseDown += PictureBox_MouseDown;
                            pictureBox.MouseMove += PictureBox_MouseMove;
                            pictureBox.MouseUp += PictureBox_MouseUp;
                            AddImg(pictureBox);
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Receive method: " + ex.Message);
                    // Handle exceptions or close the connection
                    Close();
                }
            }

        }

        private SocketData DeserializeDrawingData(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryReader reader = new BinaryReader(ms);
                Color penColor = Color.FromArgb(reader.ReadInt32());
                int width = reader.ReadInt32();
                Point oldPos = new Point(reader.ReadInt32(), reader.ReadInt32());
                Point currentPos = new Point(reader.ReadInt32(), reader.ReadInt32());

                return new SocketData(penColor, width, oldPos, currentPos);
            }
        }

        private byte[] SerializeData(SocketData drawingData)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryWriter writer = new BinaryWriter(ms);
                writer.Write(drawingData.PenColor.ToArgb());
                writer.Write(drawingData.Width);
                writer.Write(drawingData.OldPos.X);
                writer.Write(drawingData.OldPos.Y);
                writer.Write(drawingData.CurrentPos.X);
                writer.Write(drawingData.CurrentPos.Y);
                return ms.ToArray();
            }
        }

        private void btn_Paste_Click(object sender, EventArgs e)
        {
            pictureBox = new PictureBox
            {
                Image = Clipboard.GetImage(),
                SizeMode = PictureBoxSizeMode.AutoSize,
            };
            pictureBox.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            panel1.Controls.Add(pictureBox);
            SendPicture(pictureBox.Image);
        }



        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Location.X >= pictureBox.Width - 10 && e.Location.Y >= pictureBox.Height - 10)
                {
                    isResizing = true;
                }
                else
                {
                    isDragging = true;
                }
                lastMousePosition = e.Location;
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBox.Left += e.X - lastMousePosition.X;
                pictureBox.Top += e.Y - lastMousePosition.Y;
            }
            else if (isResizing)
            {
                pictureBox.Width += e.X - lastMousePosition.X;
                pictureBox.Height += e.Y - lastMousePosition.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                isResizing = false;
            }
        }

        private void AddImg(PictureBox pictureBox)
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.panel1.Controls.Add(pictureBox);
                });
            }
            else
            {
                this.panel1.Controls.Add(pictureBox);
            }
        }
    }



    public class IPanel : Panel
    {
        public IPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
