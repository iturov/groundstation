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
    public class Graphics
    {
        #region varibles
        private Form1 form;
        private Point baseForm = new Point(0,0);
        private static int logoHeightMax = Properties.Settings.Default.logoSizeMax;
        private static int logoHeightMin = Properties.Settings.Default.logoSizeMin;
        private Size logoSizeMin = new Size(logoHeightMin, logoHeightMin);
        private Size logoSizeMax = new Size(logoHeightMax, logoHeightMax);
        private int menuPanelWidthMax = Properties.Settings.Default.menuPanelWidthMax;
        private int menuPanelWidthMin = Properties.Settings.Default.menuPanelWidthMin;
        private static int buttonHeight = Properties.Settings.Default.buttonHeight;
        private Bitmap maximizeIcon = new Bitmap(Properties.Resources.maximizeIcon);
        private Bitmap minimizeIcon = new Bitmap(Properties.Resources.minimizeIcon);
        private Bitmap maximizeIconConnection = new Bitmap(Properties.Resources.LoginRoundedDown_32px);
        private Bitmap minimizeIconConnection = new Bitmap(Properties.Resources.LoginRoundedUp_32px);
        private static int connectionMenuWidth = Properties.Settings.Default.connectionMenuSize;
        private static int connectionButtonNumber = Properties.Settings.Default.connectionButtonNumber;
        private Size connectionMenuSize = new Size(connectionMenuWidth, connectionButtonNumber * buttonHeight);
        //private Point connectionPanelClosed = new Point(Screen.PrimaryScreen.Bounds.Width - );
        #endregion varibles

        #region publicFunctions
        public Graphics(Form1 form)
        {
            this.form = form;
        }

        public void initialize()
        {
            form.WindowState = FormWindowState.Maximized;

            form.logoBox.Location = baseForm;
            form.logoBox.Size = logoSizeMin;

            form.menuPanel.Location = baseForm;
            form.menuPanel.Size = new Size(menuPanelWidthMax, form.Height);

            form.settingsButton.Size = new Size(200, buttonHeight);
            form.settingsButton.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + logoHeightMin);

            form.infoButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.infoButton, 3);

            form.minMaxButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.minMaxButton, 6);

            form.exitButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.exitButton, 1);

            form.aboutButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.aboutButton, 2);

            form.telemetryButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.telemetryButton, 4);

            form.pidButton.Size = new Size(200, buttonHeight);
            setLocationButtonSettings(form.pidButton, 5);


            form.connectionPanel.Size = connectionMenuSize;
            

            form.settingsPanel.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + logoHeightMax + form.settingsButton.Height);

            form.tiling.Location = baseForm;
            form.tiling.SizeMode = PictureBoxSizeMode.CenterImage;
            form.tiling.Size = new Size(form.Width, form.Height);

            form.cameraFeed.Location = baseForm;
            form.cameraFeed.SizeMode = PictureBoxSizeMode.StretchImage;
            form.cameraFeed.Size = new Size(form.Width,form.Height);
            form.cameraFeed.SendToBack();

            //form.connectionPanel.Parent = form.cameraFeed;
            //form.menuPanel.Parent = form.cameraFeed;
            //CHANGED
            form.connectionPanel.Parent = form.cameraFeed;
            form.menuPanel.Parent = form.cameraFeed;
            form.tiling.Parent = form.cameraFeed;
            //CHANGED
            
        }


        public void update(bool leftPanelOpen, bool connectionPanelOpen, bool cameraState)
        {
            if (leftPanelOpen)
            {
                form.menuPanel.Size = new Size(menuPanelWidthMax, form.Height);
                form.logoBox.Size = logoSizeMax;
                form.settingsButton.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + logoHeightMax);
                form.minMaxButton.Image = minimizeIcon;
                form.settingsPanel.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + logoHeightMax + form.settingsButton.Height);
                form.settingsPanel.Visible = true;

            }
            else
            {
                form.menuPanel.Size = new Size(menuPanelWidthMin, form.Height);
                form.logoBox.Size = logoSizeMin;
                form.settingsButton.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + logoHeightMin);
                form.minMaxButton.Image = maximizeIcon;
                form.settingsPanel.Visible = false;

            }

            if (connectionPanelOpen)
            {
                form.connectionPanel.Location = new Point(form.Width - form.connectionPanel.Width, 0);
                form.minMaxConnectionPanelButton.Image = minimizeIconConnection;
                form.minMaxConnectionPanelButton.Text = "Minimize";
            }
            else
            {
                form.connectionPanel.Location = new Point(form.Width - form.connectionPanel.Width, -(connectionButtonNumber-1) * buttonHeight);
                form.minMaxConnectionPanelButton.Image = maximizeIconConnection;
                form.minMaxConnectionPanelButton.Text = "Maximize";
            }

            if (cameraState)
            {
                form.cameraPlayButton.Image = Properties.Resources.Pause_32px;
                form.cameraPlayButton.Text = "    Disconnect Camera!";
            }
            else
            {
                form.cameraPlayButton.Image = Properties.Resources.Play_32px;
                form.cameraPlayButton.Text = "    Connect Camera!";
            }

        }
        #endregion publicFunctions

        #region privateFunctions
        private void setLocationButtonSettings(Button button, int location)
        {
            button.Size = new Size(200, buttonHeight);
            button.Location = new Point(form.menuPanel.Location.X, form.menuPanel.Location.Y + Screen.PrimaryScreen.Bounds.Height - buttonHeight * location);
        }
        #endregion privateFunctions
    }
}
