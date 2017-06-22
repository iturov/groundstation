using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ROV_GCS_V3
{
    class Vehicle
    {
        #region variables
        Form1 form;
        public BackgroundWorker tcp = new BackgroundWorker();
        public static string[] dataReceived = new string[32];
        public static string[] dataSent = new string[16];
        public static string[] roboticArm = new string[8];
        // static TcpListener server;
        public static TcpListener server;
        static IPAddress localAddr = IPAddress.Any;
        public static string data = null;
        static Byte[] bytes = new Byte[256];
        public static TcpClient client;
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();

        #endregion variables

        #region publicFunctions
        public Vehicle(Form1 form)
        {
            this.form = form;
        }

        public void Connect(int Port = 8092)
        {
            Variables.connectionState = true;
            timer.Enabled = false;
            timer2.Enabled = false;
            if (tcp.IsBusy) tcp.CancelAsync();
            if (!(client == null)) client.Close();
            if (!(server == null)) server.Stop();

            server = new TcpListener(IPAddress.Any, Port);
            server.Start();

            if (!tcp.IsBusy)
            {
                tcp.WorkerReportsProgress = false;
                tcp.WorkerSupportsCancellation = true;
                tcp.DoWork += listen;
                tcp.RunWorkerAsync();
            }

            timer.Elapsed += timer_Tick;
            timer.Interval = 10;
            timer.Enabled = true;

            timer2.Elapsed += timer2_Tick;
            timer2.Interval = 10;
            timer2.Enabled = true;
        }

        public void Disconnect()
        {
            Variables.connectionState = false;
            if (tcp.IsBusy) tcp.CancelAsync();
            try { server.Stop(); client.Close();}
            catch (Exception exx) { }
        }
        #endregion publicFunctions

        #region privateFunctions

        private void timer_Tick(object sender, EventArgs e)
        {
            try { SendDataAnyway(); }
            catch (Exception exc) { }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //readDataAnyway();
        }

        public static void SendDataAnyway()
        {
            string[] dataArray = new string[16];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = "0";
            }

            if (Variables.controllerStatus)
            {
                dataArray[0] = Controller.controllerData[3].ToString(); // Throttle 
                dataArray[1] = Controller.controllerData[5].ToString(); // foward/back
                dataArray[2] = Controller.controllerData[4].ToString(); // right/left
                dataArray[3] = Controller.controllerData[2].ToString();  //ROLL
                dataArray[4] = Controller.controllerData[16].ToString(); //YAW  %20 of 1000 uS
                dataArray[5] = Controller.robotValues[0].ToString(); //gripper
                dataArray[6] = Controller.robotValues[1].ToString(); //rollelbow
                dataArray[7] = Controller.robotValues[2].ToString(); //pitchelbow
                dataArray[8] = Controller.robotValues[3].ToString(); //light
                dataArray[9] = Controller.robotValues[4].ToString(); //cameraservo
                //dataArray[9] = PIDCalculator.Kp.ToString();
            }
            

            string outgoingData = dataArray[0] + "," + dataArray[1] + "," + dataArray[2] + "," + dataArray[3] + "," + dataArray[4] + "," + dataArray[5] + "," + dataArray[6] + "," + dataArray[7] + "," + dataArray[8] + "," + dataArray[9] + "\n";
            if (sWriter == null) return;
            try
            {
                sWriter.WriteLine(outgoingData);
                sWriter.Flush();
            }
            catch(Exception except)
            {

            }
            
        }

        public static void readDataAnyway()
        {
            try
            {
                data = sRead.ReadLine();
                string[] receivedString = data.Split(',');
                for (int k = 0; k < receivedString.Length; k++)
                {
                    dataReceived[k] = receivedString[k];
                }
            }
            catch (Exception except)
            {

            }
            
        }

        public static StreamWriter sWriter = null;
        public static StreamReader sRead = null;

        private static void listen(object sender, DoWorkEventArgs e)
        {
            if (Variables.connectionState)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
                    sRead = new StreamReader(client.GetStream(), Encoding.ASCII);
                    while (true)
                    {
                        readDataAnyway();
                    }
                }
                catch (Exception exc)
                {

                }
            }
            
        }

        #endregion privateFunctions
    }
}
