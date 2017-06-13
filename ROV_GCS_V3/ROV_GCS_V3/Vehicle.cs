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
        BackgroundWorker tcp = new BackgroundWorker();
        BackgroundWorker tcplisten = new BackgroundWorker();
        public static string[] dataReceived = new string[32];
        public static string[] dataSent = new string[16];
        public static string[] roboticArm = new string[8];
        // static TcpListener server;
        public static TcpListener server;
        static IPAddress localAddr = IPAddress.Any;
        static String data = null;
        static Byte[] bytes = new Byte[256];
        public static TcpClient client;
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();

        public static NetworkStream stream;
        #endregion variables

        

        #region publicFunctions
        public Vehicle(Form1 form)
        {
            this.form = form;
        }

        public void Connect(int Port = 8092)
        {
            if (tcplisten.IsBusy) tcplisten.CancelAsync();
            if (tcp.IsBusy) tcp.CancelAsync();
            if (!(server == null)) server.Stop();
            server = new TcpListener(IPAddress.Any, Port);
            server.Start();

            if (!tcp.IsBusy)
            {
                tcp.WorkerReportsProgress = false;
                tcp.WorkerSupportsCancellation = true;
                tcp.DoWork += write;
                tcp.RunWorkerAsync();
            }
            if (!tcplisten.IsBusy)
            {
                tcplisten.WorkerReportsProgress = false;
                tcplisten.WorkerSupportsCancellation = true;
                tcplisten.DoWork += listen;
                tcplisten.RunWorkerAsync();
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
            if (tcp.IsBusy) tcp.CancelAsync();
            if (tcplisten.IsBusy) tcplisten.CancelAsync();
        }
        #endregion publicFunctions

        #region privateFunctions

        private void timer_Tick(object sender, EventArgs e)
        {
            SendDataAnyway();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //readDataAnyway();
        }

        public static void SendDataAnyway()
        {
            string[] dataArray = new string[16];
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
            data = sRead.ReadLine();
            string[] receivedString = data.Split(',');
            for (int k = 0; k < receivedString.Length; k++)
            {
                dataReceived[k] = receivedString[k];
            }
        }

        public static StreamWriter sWriter = null;
        public static StreamReader sRead = null;
        private static void write(object sender, DoWorkEventArgs e)
        {
            client = server.AcceptTcpClient();
            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            sRead = new StreamReader(client.GetStream(), Encoding.ASCII);
            while (true)
            {
                string[] dataArray = new string[16];
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
                                                                     //Console.WriteLine(dataArray[5]);

                //byte[] msg = System.Text.Encoding.ASCII.GetBytes(outgoingData);
                /*
                EMRE
                string outgoingData = dataArray[0] + "," + dataArray[1] + "," + dataArray[2] + "," + dataArray[3] + "," + dataArray[4] + "," + dataArray[5] + "," + dataArray[6] + "," + dataArray[7] + "," + dataArray[8] + "," + dataArray[9] + "\n";
                sWriter.WriteLine(outgoingData);
                sWriter.Flush();
                Thread.Sleep(10);
                */

                readDataAnyway();


            }
        }


        private static void listen(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //SendDataAnyway();
            }
        }
        #endregion privateFunctions

    }
}
