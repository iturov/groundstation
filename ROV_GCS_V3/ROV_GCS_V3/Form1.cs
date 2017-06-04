using AForge.Video;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ROV_GCS_V3
{
    public partial class Form1 : Form
    {
        #region variables
        Graphics graphics; // CREATE GRAPHICS OBJECT
        public Variables variables; // CREATE VARIABLES OBJECT
        Vehicle vehicle; // CREATE VEHICLE OBJECT
        Camera camera; // CREATE CAMERA OBJECT
        Controller controller; // CREATE CONTROLLER OBJECT
        public int[] controllerData = new int[32]; // DEFINE CONTROLLER DATA TO BE POLLED
        #endregion variables

        #region eventsAndFunctions
        public Form1()
        {
            InitializeComponent();
            graphics = new Graphics(this); // ADD GRAPHICS OBJECT 
            variables = new Variables(); // ADD VARIABLES OBJECT 
            controller = new Controller(this); // ADD CONTROLLER OBJECT 
            vehicle = new Vehicle(this); // ADD VEHICLE OBJECT 
        }

        private void newFrame(object sender, NewFrameEventArgs eventargs) // NEW FRAME CAPTURING EVENT
        {
            try
            {
                cameraFeed.Image = (Bitmap)eventargs.Frame.Clone(); // CLONE INCOMING BITMAP TO PICTURE BOX
            }
            catch (Exception e)
            {
                Console.WriteLine("newline:" + e.ToString());  // PRINT BUGS
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics.initialize(); // INITIALIZE GRAPHICS
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState); // UPDATE GRAPHICS WITH THE VARIABLES AS DEFAULT
            camera = new Camera(); // ADD CAMERA OBJECT
            camera.EventHandler += newFrame; // ADD NEW FRAME EVENT TO THE CAMERA EVENTHANDLER
            camera.initialize(cameraIPBox.Text, Int32.Parse(cameraPortBox.Text)); // INITALIZE CAMERA WITH THE GIVEN PARAMETERS
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = true; // SET LEFT PANEL STATE TO OPEN
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState); // UPDATE GRAPHICS WITH VARIABLES

        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = !variables.leftPanelOpen; // CHANGE MAXIMIZED/MINIMIZED STATE OF LEFT PANEL
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState); // UPDATE GRAPHICS
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit(); // CLOSE APPLICATION
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (joyStickBox.SelectedItem.ToString() == "DualShock 3") Variables.controllerType = 1; //SET CONTROLLER TYPE
            if (joyStickBox.SelectedItem.ToString() == "DualShock 2") Variables.controllerType = 0; //SET CONTROLLER TYPE
        }


        private void minMaxConnectionPanelButton_Click(object sender, EventArgs e)
        {
            variables.connectionPanelOpen = !variables.connectionPanelOpen;// CHANGE MAXIMIZED/MINIMIZED STATE OF CONNECTION PANEL
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState); // UPDATE GRAPHICS
        }

        private void logoBox_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/iturov"); // NAVIGATE TO GITHUB PAGE WHEN CLICKED TO PICTURE
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs(); // CREATE ABOUT US FORM
            au.ShowDialog(); // INITALIZE ABOUT US FORM
        }

        private void cameraPlayButton_Click(object sender, EventArgs e)
        {

            variables.cameraState = !variables.cameraState; //CHANGE CAMERA STATE
            camera.update(variables.cameraState ,cameraIPBox.Text,Int32.Parse(cameraPortBox.Text)); // UPDATE CAMERA STATE
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState); // UPDATE GRAPHICS
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            variables.cameraState = false; //SET CAMERA STATE TO FALSE TO STOP STREAMING
            camera.update(variables.cameraState, cameraIPBox.Text, Int32.Parse(cameraPortBox.Text)); // UPDATE CAMERA(EXECUTE DISCONNECTING)
            vehicle.Disconnect(); // DISCONNECT FROM VEHICLE (ABORT TCP/IP CONNECTION)
            controller.StopPoll(); // STOP POLLING DATA FROM CONTROLLER, DISCONNECT CONTROLLER
            Thread.Sleep(100); // WAIT FOR 100 MS 
            // EXIT!
        }

        private void vehicleConnectButton_Click(object sender, EventArgs e)
        {
            vehicle.Connect(Int16.Parse(vehiclePortBox.Text)); // CONNECT TO THE VEHICLE ON THE GOVEN PORT NUMBER
        }

        private void controllerConnectButton_Click(object sender, EventArgs e)
        {
            controller.StartPoll(); // ATTACH CONTROLLER, START POLLING DATA
            refresher.Enabled = true; // REFRESHER TIMER ENABLED
            //THE REFRESHING VALUES SHOULD BE DONE BY RAISING EVENTS, NOT WITH A TIMER :)
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            joyStickStatusLabel.Text = controllerData[3].ToString(); // ON EVERY TICK, LABEL UPDATES WITH THE THROTTLE VALUE FROM CONTROLLER
            joyStickStatusLabel.Text = Vehicle.dataReceived[0];

        }
        #endregion eventsAndFunctions

        private void telemetryButton_Click(object sender, EventArgs e)
        {
            Telemetry t = new Telemetry();
            t.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
