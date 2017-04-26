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
using SharpDX.DirectInput;


namespace ROV_GCSv2
{
    
    public partial class Form1 : Form
    {
        public class Camera
        {
            public event NewFrameEventHandler EventHandler;
            private MJPEGStream stream = null;
            public void CameraInitialize(string ip = "192.168.137.69", int port = 8091)
            {
                stream = new MJPEGStream("http://" + ip + ":" + port.ToString() + "/?action=stream");
                stream.NewFrame += new NewFrameEventHandler(EventHandler);
                stream.Source = "http://" + ip + ":" + port.ToString() + "/?action=stream";
            }
            public void CameraUpdate(int state, string ip = "192.168.137.69", int port = 8091)
            {
                //stream.Source = "http://" + ip + ":" + port.ToString() + "/?action=stream";
                if (state == 1)
                {
                    if (stream.IsRunning)
                    {

                    }
                    else
                    {
                    stream.Start();
                    }
                }
                else
                {
                    if (stream.IsRunning) stream.Stop();
                    else return;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        static string connectionStatus;
        static string kk;
        static int[] joystickData = new int[32];
        static int cameraEnabled = 0;
        static int controllerType;
        public static string[] dataReceived = new string[6];
        public static string[] dataSent = new string[32];
        static int[] roboticArm = new int[5];
        static int lightIntensityMaster;

        private BackgroundWorker myJoystick = new BackgroundWorker();
        private BackgroundWorker myTcp = new BackgroundWorker();
        private Camera rc = new Camera();
        
        private void newFrame(object sender, NewFrameEventArgs eventargs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventargs.Frame.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("newline:" + e.ToString());
            }
        } // FOR CAPTURING NEW FRAMES

        private int iteration = 0;
        private void JoyStickCall(object sender, DoWorkEventArgs e)
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
                    Application.DoEvents();
                    Thread.Sleep(1);

                    //joystickData[0] = mapInt(Int32.Parse(datas.PointOfViewControllers.GetValue(0).ToString()), 0, 65534, 0, 255); 
                    //joystickData[1] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, 0, 255, 1); // min is bottom max is top L-STICK UP-DOWN "0-255"
                    joystickData[2] = mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -150, 150); //L-STICK LEFT-RIGHT "-500-500" //roll %30 of 1000 us, total 300 uS
                    joystickData[3] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, -350, 350, 1); //L-STICK UP-DOWN //throttle %70 of 1000 uS, total 700 uS

                    if (controllerType == 1)
                    {
                        //FOR DUALSHOCK 3
                        joystickData[4] = mapInt(Int32.Parse(datas.RotationX.ToString()), 0, 65534, -400, 400);//R-STICK LEFT-RIGHT "-1000 -1000"  %40 of 1000 us, OTHER %20 IS FOR YAW AXIS
                        joystickData[5] = mapInt(Int32.Parse(datas.RotationY.ToString()), 0, 65534, -400, 400, 1);//R-STICK UP-DOWN "--1000-1000"  %40 of 1000 us
                    }
                    if (controllerType == 0)
                    {
                        //FOR DUALSHOCK 2
                        joystickData[4] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -400, 400);
                        joystickData[5] = mapInt(Int32.Parse(datas.RotationZ.ToString()), 0, 65534, -400, 400, 1);
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
                    joystickData[16] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -200, 200); //R2 L2 --Yaw value %20 of 1000 us
                    //DEBUGGING
                    //var datass = joystick.GetBufferedData();
                    //foreach (var dt in datass)
                    //   Console.WriteLine(dt);
                    //DEBUGGING



                    iteration = iteration + 1;
                    System.Threading.Thread.Sleep(5);
                    Application.DoEvents();
                }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            graphicsInit();
            rc.EventHandler += newFrame;
            rc.CameraInitialize();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Begin Camera

            cameraEnabled = 1;
            rc.CameraUpdate(cameraEnabled);
        }
        public static void Listen(object sender, DoWorkEventArgs e)
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 8092(USER CAN CHANGE IT!).
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
                            kk = data;
                            string[] receivedString = data.Split(',');

                            for (int k = 0; k < receivedString.Length; k++)
                            {
                                dataReceived[k] = receivedString[k];
                            }
                            string[] dataArray = new string[16];
                            for (int dat = 0; dat < dataSent.Length; dat++)
                            {
                                dataSent[dat] = "0";
                            }
                            dataArray[0] = joystickData[3].ToString(); // Throttle 
                            dataArray[1] = joystickData[5].ToString(); // foward/back
                            dataArray[2] = joystickData[4].ToString(); // right/left
                            dataArray[3] = roboticArm[3].ToString(); // Light intensity value
                            dataArray[4] = roboticArm[0].ToString(); //Robot Arm elbow1
                            dataArray[5] = roboticArm[1].ToString(); //robot arm elbow2
                            dataArray[6] = roboticArm[2].ToString(); //robot arm elbow3/gripper
                            dataArray[7] = joystickData[2].ToString();  //ROLL
                            dataArray[8] = joystickData[16].ToString(); //YAW  %20 of 1000 uS
                            dataArray[9] = roboticArm[4].ToString(); //Camera servo
                            string outgoingData = dataArray[0] + "," + dataArray[1] + "," + dataArray[2] + "," + dataArray[3] + "," + dataArray[4] + "," + dataArray[5] + "," + dataArray[6] + "," + dataArray[7] + "," + dataArray[8] + "," + dataArray[9];
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(outgoingData);
                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                        }

                        // Shutdown and end connection
                        client.Close();
                    }
                }
            }
            catch (SocketException ex)
            {
                server.Stop();
                Console.WriteLine("SocketException: {0}", ex);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
        private void timer1_Tick(object sender, EventArgs e) //REFRESH VALUES
        {
            int speedFactor = 50;
            //roboticArm[0] += joystickData[16] / 20 * timer1.Interval / 50; 
            roboticArm[0] += (joystickData[10] - joystickData[12]) * speedFactor * timer1.Interval / 50; //elbow 1
            roboticArm[1] += -(joystickData[13] - joystickData[11]) * speedFactor * timer1.Interval / 50; // elbow2
            roboticArm[2] += (joystickData[8] - joystickData[6]) * speedFactor * timer1.Interval / 50; //gripper
            roboticArm[3] += (joystickData[9] - joystickData[7]) * speedFactor * timer1.Interval / 50; //LIGHT
            roboticArm[4] += (joystickData[14] - joystickData[15]) * speedFactor * timer1.Interval / 50; //CAMERA SERVO

            for (int i = 0; i < roboticArm.Length; i++)
            {
                    roboticArm[i] = constrain(roboticArm[i]);
            }
            roboticArm[3] = constrain(roboticArm[3], 0, 700);
            roboticArm[2] = constrain(roboticArm[2], 1150, 1800);
            roboticArm[4] = constrain(roboticArm[4], 600, 1800);
            int printingValue = 3;
            //RECEIVED 
            pressureLabel.Text = dataReceived[0];
            depthLabel.Text = dataReceived[1];
            tempLabel.Text = dataReceived[2];
            distLabel.Text = dataReceived[3];
            serialLabel.Text = dataReceived[4];
            if (!myTcp.IsBusy) connectionStatus = "No Connection";
            connectionStatusLabel.Text = connectionStatus;
            throttleLabel.Text = roboticArm[2] + "% Percent";
        }

        public int constrain(int value,int min = 600, int max = 2200)
        {
            if (value > max) value = max;
            if (value < min) value = min;
            return value;
        }
        private void button2_Click(object sender, EventArgs e) // CLOSING EVENT
        {
            if(myTcp.IsBusy) myTcp.CancelAsync();
            if(myJoystick.IsBusy) myJoystick.CancelAsync();
            cameraEnabled = 0;
            rc.CameraUpdate(cameraEnabled);
            Application.Exit();
        }
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

        private void joystickType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (joystickType.SelectedItem.ToString() == "DualShock 2") controllerType = 0;
            if (joystickType.SelectedItem.ToString() == "DualShock 3") controllerType = 1;
        }

        private void connectController_Click(object sender, EventArgs e)
        {
            if (!myJoystick.IsBusy)
            {
                myJoystick.WorkerReportsProgress = false;
                myJoystick.WorkerSupportsCancellation = true;
                myJoystick.DoWork += JoyStickCall;
                myJoystick.RunWorkerAsync();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!myTcp.IsBusy)
            {
                myTcp.WorkerReportsProgress = false;
                myTcp.WorkerSupportsCancellation = true;
                myTcp.DoWork += Listen;
                myTcp.RunWorkerAsync();
            }
        }

        private void graphicsInit(){
            Point centerScreen = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            Point baseForm = new Point(0,0);
            Size screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Size formSize = new Size(this.Width,this.Height);

            this.WindowState = FormWindowState.Maximized;
            this.Size = screenSize; //this.Size = screenSize; FULLSCREEN
            pictureBox1.Location = new Point(0,0);
            pictureBox1.Size = screenSize;
            pictureBox1.SendToBack();

            parametersPanel.Location = baseForm;
        }
    }
}
