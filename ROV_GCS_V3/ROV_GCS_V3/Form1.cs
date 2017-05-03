using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_GCS_V3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Variables variables;
        Camera camera;
        public Form1()
        {
            InitializeComponent();
            graphics = new Graphics(this);
            variables = new Variables();
        }

        private void newFrame(object sender, NewFrameEventArgs eventargs)
        {
            try
            {
                cameraFeed.Image = (Bitmap)eventargs.Frame.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("newline:" + e.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics.initialize();
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState);
            camera = new Camera();
            camera.EventHandler += newFrame;
            camera.initialize(cameraIPBox.Text, Int32.Parse(cameraPortBox.Text));

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = true;
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState);
            
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            variables.leftPanelOpen = !variables.leftPanelOpen;
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (joyStickBox.SelectedItem.ToString() == "DualShock 3") variables.controllerType = 0;
            if (joyStickBox.SelectedItem.ToString() == "DualShock 2") variables.controllerType = 1;
        }


        private void minMaxConnectionPanelButton_Click(object sender, EventArgs e)
        {
            variables.connectionPanelOpen = !variables.connectionPanelOpen;
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState);
        }

        private void logoBox_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/iturov");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.ShowDialog();
        }

        private void cameraPlayButton_Click(object sender, EventArgs e)
        {

            variables.cameraState = !variables.cameraState;
            camera.update(variables.cameraState ,cameraIPBox.Text,Int32.Parse(cameraPortBox.Text));
            graphics.update(variables.leftPanelOpen, variables.connectionPanelOpen, variables.cameraState);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            variables.cameraState = false;
            camera.update(variables.cameraState, cameraIPBox.Text, Int32.Parse(cameraPortBox.Text));
        }
    }
}
