﻿using System;
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
using SharpDX.DirectInput;

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

        #region " Variables "
        MJPEGStream stream;
        int statePanel1 = 0;
        static int controllerType;
        static int myPort;
        static int[] joystickData = new int[32];
        static string connectionStatus = "No Connection!";
        bool dpiEnabled = false;
        Point parameterBase;
        Point panelbase;
        static int lightIntensity = 0;
        public static string[] dataReceived = new string[32];
        public static string[] dataSent = new string[32];
        Thread myTcp;
        Thread myJoystick;
        Thread myCamera;
        static int[] roboticArm = new int[4];
        static int lightIntensityMaster;
        #endregion

        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]

        #region " Functions "
        private void Form1_Load(object sender, EventArgs e)
        {
            //cameraInitialize();
            graphicsInitalize();
            //myTcp = new Thread(new ThreadStart(delegate { Listen(tcpEnable); }));
            myTcp = new Thread(Listen);
            myJoystick = new Thread(Joystick);
            timer1.Enabled = true;
            myCamera = new Thread(cameraInitialize);
            artHorpanel.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        void newFrame(object sender, NewFrameEventArgs eventargs)
        {
            try
            {
                artHorpanel.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap bmp = (Bitmap)eventargs.Frame.Clone();
                artHorpanel.Image = bmp;
            }
            catch (Exception)
            {

            }


        } // FOR CAPTURING NEW FRAMES

        private void closeButton_Click(object sender, EventArgs e) // CLOSE BUTTON 
        {
            myTcp.Abort();
            myJoystick.Abort();
            myCamera.Abort();
            this.Dispose();
        }

        private void toptitlebar1_Click(object sender, EventArgs e)// WEBSITE
        {
            System.Diagnostics.Process.Start("https://github.com/iturov");
        }

        private void button1_Click(object sender, EventArgs e) //STOP , CHANGE PARAMETERS ,RESTART
        {
            myCamera.Start();
            /*
            if (stream.IsRunning)
            {
                camStatLabel.Text = "Receiving Video Feed From:   " + "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
            }*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//IMPORTANT, STREAM HAS TO BE STOPPED BEFORE QUITTING APPLICATION
        {
            
            
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
            if (!dpiEnabled)
            {
                parameterBase = new Point(225 - pictureBox1.Width, Screen.PrimaryScreen.Bounds.Height / 2 - pictureBox1.Height / 2);//CHANGED
            }
            else
            {
                parameterBase = new Point(40 - pictureBox1.Width, Screen.PrimaryScreen.Bounds.Height / 2 - pictureBox1.Height / 2);//CHANGED
            }

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
            consoleBox.Parent = artHorpanel2;
            //artHorpanel.Image = ;
            artHorpanel2.Location = new Point(0, 0);
            artHorpanel2.Size = new Size(1920, 1080);
            artHorpanel2.BackColor = Color.Transparent;
            artHorpanel2.Parent = artHorpanel;
            artHorpanel2.SendToBack();

            artHorpanel.Location = new Point(0, 0);
            artHorpanel.Size = new Size(1920, 1080);
            artHorpanel.SendToBack();
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;

            camStatLabel.BackColor = Color.Transparent;
            toptitlebar1.BackColor = Color.Transparent;
            closeButton.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;

            camStatLabel.Parent = artHorpanel2;
            pictureBox1.Parent = artHorpanel2;
            parameterspanel.BringToFront();
            //parameterspanel.Parent = pictureBox1;
            toptitlebar1.Parent = artHorpanel2;
            closeButton.Parent = artHorpanel2;
            //consoleBox.Parent = artHorpanel;

            /***** GRAPHICS INITIALIZE *****/
        }

        private void cameraInitialize()
        {
            /***** CAMERA INITIALIZE *****/
            stream = new MJPEGStream("http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream");
            stream.NewFrame += new NewFrameEventHandler(newFrame);
            stream.Stop();
            stream.Source = "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
            stream.Start();
            /***** CAMERA INITIALIZE *****/
        }

        public void myConsole(string output)
        {
            consoleBox.AppendText("\r\n" + output);
        }

        public static void Joystick()
        {
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            // Instantiate the joystick
            var joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            // Poll events from joystick
            while (true)
            {
                joystick.Poll();
                var datas = joystick.GetCurrentState();
                //joystickData[0] = mapInt(Int32.Parse(datas.PointOfViewControllers.GetValue(0).ToString()), 0, 65534, 0, 255); 
                //joystickData[1] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, 0, 255, 1); // min is bottom max is top L-STICK UP-DOWN "0-255"
                joystickData[2] = mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -500, 500); //L-STICK LEFT-RIGHT "-500-500"
                joystickData[3] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, -500, 500, 1); //L-STICK UP-DOWN

                if (controllerType == 1)
                {
                    //FOR DUALSHOCK 3
                    joystickData[4] = mapInt(Int32.Parse(datas.RotationX.ToString()), 0, 65534, -1000, 1000);//R-STICK LEFT-RIGHT "-1000 -1000"
                    joystickData[5] = mapInt(Int32.Parse(datas.RotationY.ToString()), 0, 65534, -1000, 1000, 1);//R-STICK UP-DOWN "--1000-1000"
                }
                if (controllerType == 0)
                {
                    //FOR DUALSHOCK 2
                    joystickData[4] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -1000, 1000);
                    joystickData[5] = mapInt(Int32.Parse(datas.RotationZ.ToString()), 0, 65534, -1000, 1000, 1);
                }
                joystickData[6] = Convert.ToInt32(datas.Buttons.GetValue(2)); //SQUARE
                joystickData[7] = Convert.ToInt32(datas.Buttons.GetValue(1)); //O
                joystickData[8] = Convert.ToInt32(datas.Buttons.GetValue(0)); //X
                joystickData[9] = Convert.ToInt32(datas.Buttons.GetValue(3)); //Triangle
                joystickData[10] = Convert.ToInt32(datas.Buttons.GetValue(7)); //START
                joystickData[11] = Convert.ToInt32(datas.Buttons.GetValue(5)); //R1
                joystickData[12] = Convert.ToInt32(datas.Buttons.GetValue(6)); //SELECT
                joystickData[13] = Convert.ToInt32(datas.Buttons.GetValue(4)); //L1
                joystickData[14] = Convert.ToInt32(datas.Buttons.GetValue(9)); //R3
                joystickData[15] = Convert.ToInt32(datas.Buttons.GetValue(8)); //L3
                joystickData[16] = -mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -500, 500); //R2 L2 --Yaw value 
                //DEBUGGING
                var datass = joystick.GetBufferedData();
                foreach (var dt in datass)
                   Console.WriteLine(dt);
                //DEBUGGING
            }
        } // MAIN JOYSTICK FUNCTION

        private static int mapInt(int value, int currentMin, int currentMax, int targetMin, int targetMax, int reverse = 0)
        {
            int st1, st2;
            if (reverse == 1)
            {
                st1 = currentMin;
                st2 = currentMax;
                currentMin = st2;
                currentMax = st1;
            }

            int range = (currentMax - currentMin);
            int rangeT = targetMax - targetMin;
            value = (value - currentMin) * rangeT / range + targetMin;
            return value;
        }

        public static void Listen()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 8092(USER CAN CHANGE IT!).
                Int32 port = myPort;
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
                    TcpClient client = server.AcceptTcpClient();
                    //myConsole("Connected!");
                    if (!client.Connected)
                    {
                        connectionStatus = "No Connection!";
                        return;
                    }
                    else
                    {
                        connectionStatus = "Connection Established!";
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
                            dataArray[0] = joystickData[3].ToString(); // Throttle 
                            dataArray[1] = joystickData[5].ToString(); // foward/back
                            dataArray[2] = joystickData[4].ToString(); // right/left
                            dataArray[3] = (lightIntensityMaster).ToString(); // Light intensity value
                            dataArray[4] = roboticArm[0].ToString(); //Robot Arm elbow1
                            dataArray[5] = roboticArm[1].ToString(); //robot arm elbow2
                            dataArray[6] = roboticArm[2].ToString(); //robot arm elbow3/gripper
                            dataArray[7] = joystickData[2].ToString();  //ROLL
                            dataArray[8] = joystickData[16].ToString(); //YAW

                            string outgoingData = dataArray[0] + "," + dataArray[1] + "," + dataArray[2] + "," + dataArray[3] + "," + dataArray[4] + "," + dataArray[5] + "," + dataArray[6] + "," + dataArray[7] + "," + dataArray[8];
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(outgoingData);
                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                        }

                        // Shutdown and end connection
                        client.Close();
                    }
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

            lightIntensity = lightBar.Value * 70;
            lightIntensityMaster = lightIntensity;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Enabled")
            {
                dpiEnabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Disabled")
            {
                dpiEnabled = false;
            }
            statePanel1 = 0;
            graphicsInitalize();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            myPort = Int32.Parse(textBox1.Text);
            myTcp.Start();
        }

        int limits(int value, int min, int max)
        {
            if (value > max) value = max;
            if (value < min) value = min;
            return value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speedFactor = 25;
            label6.Text = connectionStatus;
            roboticArm[0] += joystickData[16] / 20 * timer1.Interval / 50;
            roboticArm[1] += -(joystickData[13] - joystickData[11]) * speedFactor * timer1.Interval / 50;
            roboticArm[2] += (joystickData[8] - joystickData[6]) * speedFactor * timer1.Interval / 50;
            roboticArm[3] += (joystickData[9] - joystickData[7]) * speedFactor * timer1.Interval / 50; //LIGHT!!!!!

            for (int i = 0; i < roboticArm.Length; i++)
            {
                roboticArm[i] = limits(roboticArm[i], 0, 1000);
            }
            roboticArm[3] = limits(roboticArm[3], 0, 700);
            if (!((joystickData[9] - joystickData[7]) == 0))
            {
                lightIntensityMaster = roboticArm[3];
            }
            else
            {
                roboticArm[3] = lightIntensityMaster;
            }
            lightPercent.Text = (lightBar.Value * 10).ToString() + "%"; //Light Intensity Display
            lightBar.Value = lightIntensityMaster / 70;
            label8.Text = lightIntensityMaster.ToString();
            referanceTextJoy.Text = "Throttle: " + joystickData[3].ToString() + "Percent";
            camStatLabel.Text = "Receiving Video Feed From:   " + "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/?action=stream";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "DualShock2") controllerType = 0;
            if (comboBox2.SelectedItem.ToString() == "DualShock3") controllerType = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myJoystick.Start();
        }
        #endregion
    }
}
