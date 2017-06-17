using AForge.Video;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        float prevAngle = 0;
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
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS WITH THE VARIABLES AS DEFAULT
            camera = new Camera(); // ADD CAMERA OBJECT
            camera.EventHandler += newFrame; // ADD NEW FRAME EVENT TO THE CAMERA EVENTHANDLER
            camera.initialize(cameraIPBox.Text, Int32.Parse(cameraPortBox.Text)); // INITALIZE CAMERA WITH THE GIVEN PARAMETERS
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = true; // SET LEFT PANEL STATE TO OPEN
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS WITH VARIABLES

        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = !variables.leftPanelOpen; // CHANGE MAXIMIZED/MINIMIZED STATE OF LEFT PANEL
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (vehicle.tcp.IsBusy) vehicle.tcp.CancelAsync();
            Thread.Sleep(100); // WAIT FOR 100 MS 
            vehicle.Disconnect(); // DISCONNECT FROM VEHICLE (ABORT TCP/IP CONNECTION)
            controller.StopPoll(); // STOP POLLING DATA FROM CONTROLLER, DISCONNECT CONTROLLER
            variables.cameraState = false; //SET CAMERA STATE TO FALSE TO STOP STREAMING
            camera.update(variables.cameraState, cameraIPBox.Text, Int32.Parse(cameraPortBox.Text)); // UPDATE CAMERA(EXECUTE DISCONNECTING)
            if (!(Vehicle.client == null)) Vehicle.client.Close();
            if (!(Vehicle.server == null)) Vehicle.server.Stop();
            //Environment.FailFast("");
            try{ Application.Exit(); } // CLOSE APPLICATION
            catch (Exception exce) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (joyStickBox.SelectedItem.ToString() == "DualShock 3") Variables.controllerType = 1; //SET CONTROLLER TYPE
            if (joyStickBox.SelectedItem.ToString() == "Joystick") Variables.controllerType = 0; //SET CONTROLLER TYPE
        }


        private void minMaxConnectionPanelButton_Click(object sender, EventArgs e)
        {
            variables.connectionPanelOpen = !variables.connectionPanelOpen;// CHANGE MAXIMIZED/MINIMIZED STATE OF CONNECTION PANEL
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS
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
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // EXIT!
        }

        private void vehicleConnectButton_Click(object sender, EventArgs e)
        {
            vehicle.Connect(Int16.Parse(vehiclePortBox.Text)); // CONNECT TO THE VEHICLE ON THE GIVEN PORT NUMBER
            timer1.Enabled = true;
        }

        private void controllerConnectButton_Click(object sender, EventArgs e)
        {
            controller.StartPoll(); // ATTACH CONTROLLER, START POLLING DATA
            refresher.Enabled = true; // REFRESHER TIMER ENABLED
            //THE REFRESHING VALUES SHOULD BE DONE BY RAISING EVENTS, NOT WITH A TIMER :)
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            if (!(Vehicle.data == null)) joyStickStatusLabel.Text = Vehicle.data; // ON EVERY TICK, LABEL UPDATES WITH THE THROTTLE VALUE FROM CONTROLLER
            else if (Variables.controllerStatus) { joyStickStatusLabel.Text = "Connected!"; }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vehicle.SendDataAnyway();
            updateMagnet(variables.currentMagnetDegree, false);
        }

        private void updateMagnet(float value, bool force)
        {
            if (force)
            {
                magnetoMeterDisplay.Image = rotateImage(variables.magnetBitmap, value);
            }
            else
            {
                float error = variables.currentMagnetDegree - prevAngle;
                if (!(error == 0)) magnetoMeterDisplay.Image = rotateImage(variables.magnetBitmap, value);
                prevAngle = variables.currentMagnetDegree;
            }
            
        }

        private static Image rotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void pidButton_Click(object sender, EventArgs e)
        {
            PIDCalculator pid = new PIDCalculator();
            pid.Show();
            pid.TopMost = true;
        }

        private void magnetoMeterDisplay_MouseEnter(object sender, EventArgs e)
        {
            variables.magnetState = true;
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS
        }

        private void magnetoMeterDisplay_MouseLeave(object sender, EventArgs e)
        {
            variables.magnetState = false;
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState, variables.magnetState); // UPDATE GRAPHICS
        }
    }
}
