using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ROV_GCS_V3
{
    class Vehicle
    {
        #region variables
        Form1 form;
        BackgroundWorker tcp = new BackgroundWorker();
        public static string[] dataReceived = new string[32];
        public static string[] dataSent = new string[16];
        public static string[] roboticArm = new string[8];
        static int port;
        #endregion variables

        #region publicFunctions
        public Vehicle(Form1 form)
        {
            this.form = form;
        }

        public void Connect(int Port = 8092)
        {
            port = Port;
            if (!tcp.IsBusy)
            {
                tcp.WorkerReportsProgress = false;
                tcp.WorkerSupportsCancellation = true;
                tcp.DoWork += Listen;
                tcp.RunWorkerAsync();
            }
        }

        public void Disconnect()
        {
            if (tcp.IsBusy) tcp.CancelAsync();
        }
        #endregion publicFunctions

        #region privateFunctions
        private static void Listen(object sender, DoWorkEventArgs e)
        {
            TcpListener server = null;
            try
            {
                
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
                    if (!client.Connected)
                    {
                        Variables.connectionStatus = "No Connection!";
                        return;
                    }
                    else
                    {
                        Variables.connectionStatus = "Connection Established!";
                        data = null;
                        // Get a stream object for reading and writing
                        NetworkStream stream = client.GetStream();
                        int i;
                        // Loop to receive all the data sent by the client.
                        
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            string[] receivedString = data.Split(',');
                            for (int k = 0; k < receivedString.Length; k++)
                            {
                                dataReceived[k] = receivedString[k];
                            }
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
        #endregion privateFunctions

    }
}
