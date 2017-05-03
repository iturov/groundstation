namespace ROV_GCS_V3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cameraPortBox = new System.Windows.Forms.TextBox();
            this.cameraConnectionStatus = new System.Windows.Forms.Label();
            this.cameraIPBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.joyStickStatusLabel = new System.Windows.Forms.Label();
            this.joyStickBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.minMaxConnectionPanelButton = new System.Windows.Forms.Button();
            this.cameraPlayButton = new System.Windows.Forms.Button();
            this.vehicleConnectButton = new System.Windows.Forms.Button();
            this.controllerConnectButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minMaxButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.cameraFeed = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Controls.Add(this.settingsPanel);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.minMaxButton);
            this.menuPanel.Controls.Add(this.logoBox);
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 534);
            this.menuPanel.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.label);
            this.settingsPanel.Controls.Add(this.cameraPortBox);
            this.settingsPanel.Controls.Add(this.cameraConnectionStatus);
            this.settingsPanel.Controls.Add(this.cameraIPBox);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.joyStickStatusLabel);
            this.settingsPanel.Controls.Add(this.joyStickBox);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Location = new System.Drawing.Point(3, 166);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(200, 208);
            this.settingsPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "-NoVehicleConnected-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(13, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Camera  Port:";
            // 
            // cameraPortBox
            // 
            this.cameraPortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cameraPortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraPortBox.ForeColor = System.Drawing.Color.White;
            this.cameraPortBox.Location = new System.Drawing.Point(90, 101);
            this.cameraPortBox.Name = "cameraPortBox";
            this.cameraPortBox.Size = new System.Drawing.Size(32, 20);
            this.cameraPortBox.TabIndex = 9;
            this.cameraPortBox.Text = "8091";
            // 
            // cameraConnectionStatus
            // 
            this.cameraConnectionStatus.AutoSize = true;
            this.cameraConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.cameraConnectionStatus.Location = new System.Drawing.Point(77, 124);
            this.cameraConnectionStatus.Name = "cameraConnectionStatus";
            this.cameraConnectionStatus.Size = new System.Drawing.Size(120, 13);
            this.cameraConnectionStatus.TabIndex = 8;
            this.cameraConnectionStatus.Text = "-NoCamerasConnected-";
            // 
            // cameraIPBox
            // 
            this.cameraIPBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cameraIPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraIPBox.ForeColor = System.Drawing.Color.White;
            this.cameraIPBox.Location = new System.Drawing.Point(90, 75);
            this.cameraIPBox.Name = "cameraIPBox";
            this.cameraIPBox.Size = new System.Drawing.Size(87, 20);
            this.cameraIPBox.TabIndex = 7;
            this.cameraIPBox.Text = "192.168.137.152";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Camera IP:";
            // 
            // joyStickStatusLabel
            // 
            this.joyStickStatusLabel.AutoSize = true;
            this.joyStickStatusLabel.ForeColor = System.Drawing.Color.White;
            this.joyStickStatusLabel.Location = new System.Drawing.Point(63, 37);
            this.joyStickStatusLabel.Name = "joyStickStatusLabel";
            this.joyStickStatusLabel.Size = new System.Drawing.Size(117, 13);
            this.joyStickStatusLabel.TabIndex = 5;
            this.joyStickStatusLabel.Text = "-NoJoystickConnected-";
            // 
            // joyStickBox
            // 
            this.joyStickBox.BackColor = System.Drawing.Color.White;
            this.joyStickBox.Items.AddRange(new object[] {
            "DualShock 3",
            "DualShock 2"});
            this.joyStickBox.Location = new System.Drawing.Point(90, 9);
            this.joyStickBox.Name = "joyStickBox";
            this.joyStickBox.Size = new System.Drawing.Size(90, 21);
            this.joyStickBox.TabIndex = 4;
            this.joyStickBox.Text = "DualShock 3";
            this.joyStickBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controller Type:";
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.minMaxConnectionPanelButton);
            this.connectionPanel.Controls.Add(this.cameraPlayButton);
            this.connectionPanel.Controls.Add(this.vehicleConnectButton);
            this.connectionPanel.Controls.Add(this.controllerConnectButton);
            this.connectionPanel.Location = new System.Drawing.Point(827, 7);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(150, 296);
            this.connectionPanel.TabIndex = 4;
            // 
            // minMaxConnectionPanelButton
            // 
            this.minMaxConnectionPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.minMaxConnectionPanelButton.FlatAppearance.BorderSize = 0;
            this.minMaxConnectionPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minMaxConnectionPanelButton.ForeColor = System.Drawing.Color.White;
            this.minMaxConnectionPanelButton.Image = global::ROV_GCS_V3.Properties.Resources.LoginRoundedDown_32px;
            this.minMaxConnectionPanelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.minMaxConnectionPanelButton.Location = new System.Drawing.Point(0, 120);
            this.minMaxConnectionPanelButton.Name = "minMaxConnectionPanelButton";
            this.minMaxConnectionPanelButton.Size = new System.Drawing.Size(150, 40);
            this.minMaxConnectionPanelButton.TabIndex = 8;
            this.minMaxConnectionPanelButton.Text = "    Minimize!";
            this.minMaxConnectionPanelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minMaxConnectionPanelButton.UseVisualStyleBackColor = false;
            this.minMaxConnectionPanelButton.Click += new System.EventHandler(this.minMaxConnectionPanelButton_Click);
            // 
            // cameraPlayButton
            // 
            this.cameraPlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cameraPlayButton.FlatAppearance.BorderSize = 0;
            this.cameraPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraPlayButton.ForeColor = System.Drawing.Color.White;
            this.cameraPlayButton.Image = global::ROV_GCS_V3.Properties.Resources.Play_32px;
            this.cameraPlayButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cameraPlayButton.Location = new System.Drawing.Point(0, 80);
            this.cameraPlayButton.Name = "cameraPlayButton";
            this.cameraPlayButton.Size = new System.Drawing.Size(150, 40);
            this.cameraPlayButton.TabIndex = 7;
            this.cameraPlayButton.Text = "    Connect Camera!";
            this.cameraPlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cameraPlayButton.UseVisualStyleBackColor = false;
            this.cameraPlayButton.Click += new System.EventHandler(this.cameraPlayButton_Click);
            // 
            // vehicleConnectButton
            // 
            this.vehicleConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.vehicleConnectButton.FlatAppearance.BorderSize = 0;
            this.vehicleConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleConnectButton.ForeColor = System.Drawing.Color.White;
            this.vehicleConnectButton.Image = global::ROV_GCS_V3.Properties.Resources.Disconnected_32px;
            this.vehicleConnectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.vehicleConnectButton.Location = new System.Drawing.Point(0, 40);
            this.vehicleConnectButton.Name = "vehicleConnectButton";
            this.vehicleConnectButton.Size = new System.Drawing.Size(150, 40);
            this.vehicleConnectButton.TabIndex = 6;
            this.vehicleConnectButton.Text = "    Connect Vehicle!";
            this.vehicleConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleConnectButton.UseVisualStyleBackColor = false;
            // 
            // controllerConnectButton
            // 
            this.controllerConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.controllerConnectButton.FlatAppearance.BorderSize = 0;
            this.controllerConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controllerConnectButton.ForeColor = System.Drawing.Color.White;
            this.controllerConnectButton.Image = global::ROV_GCS_V3.Properties.Resources.Controller_32px;
            this.controllerConnectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.controllerConnectButton.Location = new System.Drawing.Point(0, 0);
            this.controllerConnectButton.Name = "controllerConnectButton";
            this.controllerConnectButton.Size = new System.Drawing.Size(150, 40);
            this.controllerConnectButton.TabIndex = 5;
            this.controllerConnectButton.Text = "    Connect Controller";
            this.controllerConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.controllerConnectButton.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = global::ROV_GCS_V3.Properties.Resources.About_32px;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 414);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(200, 40);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "    About Us!";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::ROV_GCS_V3.Properties.Resources.Close_Window_32px;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 494);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "    Exit!";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minMaxButton
            // 
            this.minMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.minMaxButton.FlatAppearance.BorderSize = 0;
            this.minMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minMaxButton.ForeColor = System.Drawing.Color.White;
            this.minMaxButton.Image = global::ROV_GCS_V3.Properties.Resources.minimizeIcon;
            this.minMaxButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.minMaxButton.Location = new System.Drawing.Point(0, 454);
            this.minMaxButton.Name = "minMaxButton";
            this.minMaxButton.Size = new System.Drawing.Size(200, 40);
            this.minMaxButton.TabIndex = 2;
            this.minMaxButton.Text = "    Minimize Bar";
            this.minMaxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minMaxButton.UseVisualStyleBackColor = false;
            this.minMaxButton.Click += new System.EventHandler(this.minMaxButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::ROV_GCS_V3.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(100, 100);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            this.logoBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoBox_MouseClick);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = global::ROV_GCS_V3.Properties.Resources.Menu_32px;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.settingsButton.Location = new System.Drawing.Point(-3, 106);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 40);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "    Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // cameraFeed
            // 
            this.cameraFeed.Location = new System.Drawing.Point(432, 87);
            this.cameraFeed.Name = "cameraFeed";
            this.cameraFeed.Size = new System.Drawing.Size(100, 50);
            this.cameraFeed.TabIndex = 9;
            this.cameraFeed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 534);
            this.Controls.Add(this.cameraFeed);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.PictureBox logoBox;
        public System.Windows.Forms.Button minMaxButton;
        public System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Button controllerConnectButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button vehicleConnectButton;
        private System.Windows.Forms.TextBox cameraIPBox;
        private System.Windows.Forms.ComboBox joyStickBox;
        private System.Windows.Forms.Label cameraConnectionStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label joyStickStatusLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox cameraPortBox;
        public System.Windows.Forms.Button cameraPlayButton;
        public System.Windows.Forms.Panel settingsPanel;
        public System.Windows.Forms.Panel connectionPanel;
        public System.Windows.Forms.Button aboutButton;
        public System.Windows.Forms.Button minMaxConnectionPanelButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox cameraFeed;
    }
}

