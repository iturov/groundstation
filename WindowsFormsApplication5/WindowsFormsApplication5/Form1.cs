using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Security.Permissions;

//THIS SOFTWARE HAS BEEN DEVELOPED BY SENCER YAZICI. FOR MORE INFORMATION PLASE CONTACT VIA EMAIL "sencer_yazici98@hotmail.com" 
// NOTE: THIS SOFTWARE IS IN DEVELOPMENT UNTER ITUROV TEAM AT ISTANBUL TECHNICAL UNIVERSITY
// VISIT GITHUB PAGE: https://github.com/iturov

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MJPEGStream stream;
        int statePanel1 = 0;
        static int tcpEnable = 1;
        
        Point parameterBase;
        Point panelbase;
        static int lightIntensity = 0;
        public static string[] dataReceived = new string[32];
        public static string[] dataSent = new string[32];
        Thread myTcp;
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void Form1_Load(object sender, EventArgs e)
        {
            cameraInitialize();
            graphicsInitalize();
            //myTcp = new Thread(new ThreadStart(delegate { Listen(tcpEnable); }));
            myTcp = new Thread(Listen);
            myTcp.Start();
        }

        void newFrame(object sender, NewFrameEventArgs eventargs)
        {
            Bitmap bmp = (Bitmap)eventargs.Frame.Clone();
            artHorpanel.Image = bmp;
        } // FOR CAPTURING NEW FRAMES

        private void closeButton_Click(object sender, EventArgs e) // CLOSE BUTTON 
        {
            myTcp.Abort();
            tcpEnable = 0;
            stream.Stop();
            this.Dispose();            
        }

        private void toptitlebar1_Click(object sender, EventArgs e)// WEBSITE
        {
            System.Diagnostics.Process.Start("https://github.com/iturov");
        }

        private void button1_Click(object sender, EventArgs e) //STOP , CHANGE PARAMETERS ,RESTART
        {
            stream.Stop();
            stream.Source ="http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
            stream.Start();
            if (stream.IsRunning)
            {
                camStatLabel.Text = "Receiving Video Feed From:   " + "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//IMPORTANT, STREAM HAS TO BE STOPPED BEFORE QUITTING APPLICATION
        {
            tcpEnable = 0;
            Application.Exit();
            this.Dispose();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int widthP = pictureBox1.Width - 50; //PANELS WIDTH
            statePanel1 += 1; // ON/OFF STATE
            if (statePanel1 >= 2) statePanel1 = 0;

            if (statePanel1 == 1) // PANEL IS CLOSED, NOW OPENING 
            {
                for (int i = 0; i < widthP; i++)
                {
                    parameterBase.X++;
                    panelbase.X++;
                    parameterspanel.Location = panelbase;
                    pictureBox1.Location = parameterBase; //PANEL'S POSITION INCREASES
                }
                    
            }
            else // PANEL IS OPEN, NOW CLOSING
            {
                for (int i = 0; i < widthP; i++)
                {
                    parameterBase.X--;
                    panelbase.X--;
                    parameterspanel.Location = panelbase;
                    pictureBox1.Location = parameterBase;//PANEL'S POSITION DECREASES
                }
                    
            }
        }

        private void consoleBox_MouseEnter(object sender, EventArgs e)
        {
            consoleBox.BorderStyle = BorderStyle.FixedSingle;
            //consoleBox.BackColor = Color.FromArgb(255, 12, 12, 12);
        }

        private void consoleBox_MouseLeave(object sender, EventArgs e)
        {
            consoleBox.BorderStyle = BorderStyle.None;
        }

        private void consoleBox_TextChanged(object sender, EventArgs e)
        {
            consoleBox.SelectionStart = consoleBox.Text.Length;
            // scroll it automatically
            consoleBox.ScrollToCaret();
        }
        
        private void graphicsInitalize()
        {
            /***** GRAPHICS INITIALIZE *****/
            this.WindowState = FormWindowState.Maximized;
            /*** DECLARE THIS VARIABLE ***/
            //string path1 = "";
            //toptitlebar1.ImageLocation = path1;
            toptitlebar1.Width = toptitlebar1.Image.Width;
            toptitlebar1.Height = toptitlebar1.Image.Height;
            toptitlebar1.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - toptitlebar1.Width / 2, 0);
            toptitlebar1.BackColor = Color.Transparent;
            /*** DECLARE THIS VARIABLE ***/
            //string path1 = "";
            //toptitlebar1.ImageLocation = path1;
            closeButton.Width = closeButton.Image.Width;
            //Screen.PrimaryScreen.
            closeButton.Height = closeButton.Image.Height;
            closeButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width - closeButton.Width, 0);
            parameterBase = new Point(225 - pictureBox1.Width, Screen.PrimaryScreen.Bounds.Height / 2 - pictureBox1.Height / 2);//CHANGED
            pictureBox1.Location = parameterBase;
            panelbase = new Point(-parameterspanel.Width, Screen.PrimaryScreen.Bounds.Height / 2 - pictureBox1.Height / 2 + 35);//CHANGED
            parameterspanel.Location = panelbase;
            camStatLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - camStatLabel.Width / 2, toptitlebar1.Height - 20);
            //artHorpanel.Location = new Point(Screen.PrimaryScreen.Bounds.Width/2 - artHorpanel.Width/2, Screen.PrimaryScreen.Bounds.Height/2 - artHorpanel.Height/2);
            consoleBox.Size = new Size(Screen.PrimaryScreen.Bounds.Width, 150);
            consoleBox.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - consoleBox.Height);
            consoleBox.BackColor = Color.FromArgb(255, 12, 12, 12);
            //consoleBox.ForeColor = Color.FromArgb(255,89,124,230);
            consoleBox.BorderStyle = BorderStyle.None;
            consoleBox.ForeColor = Color.White;
            consoleBox.BringToFront();
            consoleBox.Parent = artHorpanel;

            artHorpanel.Location = new Point(0, 0);
            artHorpanel.Size = new Size(1920, 1080);
            artHorpanel.SendToBack();
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;

            camStatLabel.BackColor = Color.Transparent;
            toptitlebar1.BackColor = Color.Transparent;
            closeButton.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            camStatLabel.Parent = artHorpanel;
            pictureBox1.Parent = artHorpanel;
            parameterspanel.BringToFront();
            //parameterspanel.Parent = pictureBox1;
            toptitlebar1.Parent = artHorpanel;
            closeButton.Parent = artHorpanel;
            //consoleBox.Parent = artHorpanel;

            /***** GRAPHICS INITIALIZE *****/
        }

        private void cameraInitialize()
        {
            /***** CAMERA INITIALIZE *****/
            //stream = new MJPEGStream("http://192.168.2.127:8091/?action=stream");
            stream = new MJPEGStream("http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream");
            stream.NewFrame += new NewFrameEventHandler(newFrame);

            camStatLabel.Text = "Receiving Video Feed From:   " + "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
            /***** CAMERA INITIALIZE *****/
        }

        public void myConsole(string output)
        {
            //Console.WriteLine(output);
            consoleBox.AppendText("\r\n" + output);
        }

        public static void Listen()
        {
            TcpListener server = null;
                try
                {
                    // Set the TcpListener on port 13000.
                    Int32 port = 8092;
                    IPAddress localAddr = IPAddress.Any;

                    // TcpListener server = new TcpListener(port);
                    server = new TcpListener(localAddr, port);

                    // Start listening for client requests.
                    server.Start();

                    // Buffer for reading data
                    Byte[] bytes = new Byte[256];
                    String data = null;

                    // Enter the listening loop.
                    while (true)
                    {
                        //myConsole("Waiting for a connection... ");

                        // Perform a blocking call to accept requests.
                        // You could also user server.AcceptSocket() here.

                        TcpClient client = server.AcceptTcpClient();
                        //myConsole("Connected!");
                        if (!client.Connected)
                        {
                            
                            return;
                        }
                        else
                        {
                            data = null;
                            // Get a stream object for reading and writing
                            NetworkStream stream = client.GetStream();

                            int i;

                            // Loop to receive all the data sent by the client.
                            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                            {
                                // Translate data bytes to a ASCII string.
                                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                                //myConsole("Received:" + data);
                                string[] receivedString = data.Split(',');
                                for (int k = 0; k < receivedString.Length; k++)
                                {
                                    Form1.dataReceived[k] = receivedString[k];
                                }
                                string[] dataArray = new string[16];
                                for (int dat = 0; dat < dataSent.Length; dat++)
                                {
                                    dataSent[dat] = "0";
                                }
                                dataArray[0] = dataSent[3]; // Throttle 
                                dataArray[1] = dataSent[4]; // 
                                dataArray[2] = dataSent[5]; // 
                                dataArray[3] = (lightIntensity * 7).ToString(); // Light intensity value

                                dataArray[4] = "";


                                string outgoingData = dataArray[0] + "," + dataArray[1] + "," + dataArray[2] + "," + dataArray[3] + "," + dataArray[4] + "," + dataArray[5] + "," + dataArray[6];

                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(outgoingData);

                                // Send back a response.
                                stream.Write(msg, 0, msg.Length);

                                //myConsole("Sent:" + data);
                            }

                            // Shutdown and end connection
                            client.Close();
                        }

                        //return;
                    }
                }
                catch (SocketException e)
                {
                    server.Stop();
                    Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    // Stop listening for new clients.
                    server.Stop();
                }


                Console.WriteLine("\nHit enter to continue...");
                Console.Read();
            

        }
        private void lightBar_Scroll(object sender, EventArgs e)
        {
            lightPercent.Text = (lightBar.Value * 10).ToString() + "%"; //Light Intensity Display
            lightIntensity = lightBar.Value * 10;
            //label1.Text = lightIntensity.ToString();
        }
    }
}
