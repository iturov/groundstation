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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pidButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.telemetryButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.vehiclePortBox = new System.Windows.Forms.TextBox();
            this.vehicleConnectionStatusLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cameraPortBox = new System.Windows.Forms.TextBox();
            this.cameraConnectionStatus = new System.Windows.Forms.Label();
            this.cameraIPBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.joyStickStatusLabel = new System.Windows.Forms.Label();
            this.joyStickBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minMaxButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.minMaxConnectionPanelButton = new System.Windows.Forms.Button();
            this.cameraPlayButton = new System.Windows.Forms.Button();
            this.vehicleConnectButton = new System.Windows.Forms.Button();
            this.controllerConnectButton = new System.Windows.Forms.Button();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.cameraFeed = new System.Windows.Forms.PictureBox();
            this.tiling = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.connectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiling)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.pidButton);
            this.menuPanel.Controls.Add(this.infoButton);
            this.menuPanel.Controls.Add(this.telemetryButton);
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
            // pidButton
            // 
            this.pidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pidButton.FlatAppearance.BorderSize = 0;
            this.pidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pidButton.ForeColor = System.Drawing.Color.White;
            this.pidButton.Image = global::ROV_GCS_V3.Properties.Resources.Cosine_32px;
            this.pidButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pidButton.Location = new System.Drawing.Point(10, 387);
            this.pidButton.Name = "pidButton";
            this.pidButton.Size = new System.Drawing.Size(200, 40);
            this.pidButton.TabIndex = 9;
            this.pidButton.Text = "    PID Settings";
            this.pidButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pidButton.UseVisualStyleBackColor = false;
            this.pidButton.Click += new System.EventHandler(this.pidButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoButton.Location = new System.Drawing.Point(-3, 330);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(200, 40);
            this.infoButton.TabIndex = 8;
            this.infoButton.Text = "    Information";
            this.infoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // telemetryButton
            // 
            this.telemetryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.telemetryButton.FlatAppearance.BorderSize = 0;
            this.telemetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telemetryButton.ForeColor = System.Drawing.Color.White;
            this.telemetryButton.Image = ((System.Drawing.Image)(resources.GetObject("telemetryButton.Image")));
            this.telemetryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.telemetryButton.Location = new System.Drawing.Point(0, 368);
            this.telemetryButton.Name = "telemetryButton";
            this.telemetryButton.Size = new System.Drawing.Size(200, 40);
            this.telemetryButton.TabIndex = 7;
            this.telemetryButton.Text = "    Telemetry";
            this.telemetryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.telemetryButton.UseVisualStyleBackColor = false;
            this.telemetryButton.Click += new System.EventHandler(this.telemetryButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
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
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.vehiclePortBox);
            this.settingsPanel.Controls.Add(this.vehicleConnectionStatusLabel);
            this.settingsPanel.Controls.Add(this.label);
            this.settingsPanel.Controls.Add(this.cameraPortBox);
            this.settingsPanel.Controls.Add(this.cameraConnectionStatus);
            this.settingsPanel.Controls.Add(this.cameraIPBox);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.joyStickStatusLabel);
            this.settingsPanel.Controls.Add(this.joyStickBox);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Location = new System.Drawing.Point(3, 141);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(200, 193);
            this.settingsPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vehicle  Port:";
            // 
            // vehiclePortBox
            // 
            this.vehiclePortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vehiclePortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehiclePortBox.ForeColor = System.Drawing.Color.White;
            this.vehiclePortBox.Location = new System.Drawing.Point(90, 150);
            this.vehiclePortBox.Name = "vehiclePortBox";
            this.vehiclePortBox.Size = new System.Drawing.Size(32, 20);
            this.vehiclePortBox.TabIndex = 12;
            this.vehiclePortBox.Text = "8092";
            // 
            // vehicleConnectionStatusLabel
            // 
            this.vehicleConnectionStatusLabel.AutoSize = true;
            this.vehicleConnectionStatusLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleConnectionStatusLabel.Location = new System.Drawing.Point(80, 173);
            this.vehicleConnectionStatusLabel.Name = "vehicleConnectionStatusLabel";
            this.vehicleConnectionStatusLabel.Size = new System.Drawing.Size(114, 13);
            this.vehicleConnectionStatusLabel.TabIndex = 11;
            this.vehicleConnectionStatusLabel.Text = "-NoVehicleConnected-";
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
            this.joyStickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.joyStickBox.Items.AddRange(new object[] {
            "DualShock 3",
            "Joystick"});
            this.joyStickBox.Location = new System.Drawing.Point(90, 9);
            this.joyStickBox.Name = "joyStickBox";
            this.joyStickBox.Size = new System.Drawing.Size(90, 21);
            this.joyStickBox.TabIndex = 4;
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
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
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
            this.minMaxButton.Image = ((System.Drawing.Image)(resources.GetObject("minMaxButton.Image")));
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
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
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
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
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
            this.minMaxConnectionPanelButton.Image = ((System.Drawing.Image)(resources.GetObject("minMaxConnectionPanelButton.Image")));
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
            this.cameraPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("cameraPlayButton.Image")));
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
            this.vehicleConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("vehicleConnectButton.Image")));
            this.vehicleConnectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.vehicleConnectButton.Location = new System.Drawing.Point(0, 40);
            this.vehicleConnectButton.Name = "vehicleConnectButton";
            this.vehicleConnectButton.Size = new System.Drawing.Size(150, 40);
            this.vehicleConnectButton.TabIndex = 6;
            this.vehicleConnectButton.Text = "    Connect Vehicle!";
            this.vehicleConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleConnectButton.UseVisualStyleBackColor = false;
            this.vehicleConnectButton.Click += new System.EventHandler(this.vehicleConnectButton_Click);
            // 
            // controllerConnectButton
            // 
            this.controllerConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.controllerConnectButton.FlatAppearance.BorderSize = 0;
            this.controllerConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controllerConnectButton.ForeColor = System.Drawing.Color.White;
            this.controllerConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("controllerConnectButton.Image")));
            this.controllerConnectButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.controllerConnectButton.Location = new System.Drawing.Point(0, 0);
            this.controllerConnectButton.Name = "controllerConnectButton";
            this.controllerConnectButton.Size = new System.Drawing.Size(150, 40);
            this.controllerConnectButton.TabIndex = 5;
            this.controllerConnectButton.Text = "    Connect Controller";
            this.controllerConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.controllerConnectButton.UseVisualStyleBackColor = false;
            this.controllerConnectButton.Click += new System.EventHandler(this.controllerConnectButton_Click);
            // 
            // refresher
            // 
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // cameraFeed
            // 
            this.cameraFeed.BackColor = System.Drawing.Color.Transparent;
            this.cameraFeed.Location = new System.Drawing.Point(432, 87);
            this.cameraFeed.Name = "cameraFeed";
            this.cameraFeed.Size = new System.Drawing.Size(100, 50);
            this.cameraFeed.TabIndex = 9;
            this.cameraFeed.TabStop = false;
            // 
            // tiling
            // 
            this.tiling.BackColor = System.Drawing.Color.Transparent;
            this.tiling.Image = ((System.Drawing.Image)(resources.GetObject("tiling.Image")));
            this.tiling.Location = new System.Drawing.Point(407, 207);
            this.tiling.Name = "tiling";
            this.tiling.Size = new System.Drawing.Size(100, 50);
            this.tiling.TabIndex = 10;
            this.tiling.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 534);
            this.Controls.Add(this.tiling);
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
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.connectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiling)).EndInit();
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox cameraPortBox;
        public System.Windows.Forms.Button cameraPlayButton;
        public System.Windows.Forms.Panel settingsPanel;
        public System.Windows.Forms.Panel connectionPanel;
        public System.Windows.Forms.Button aboutButton;
        public System.Windows.Forms.Button minMaxConnectionPanelButton;
        private System.Windows.Forms.Label vehicleConnectionStatusLabel;
        public System.Windows.Forms.PictureBox cameraFeed;
        private System.Windows.Forms.Timer refresher;
        public System.Windows.Forms.Label joyStickStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vehiclePortBox;
        public System.Windows.Forms.Button telemetryButton;
        public System.Windows.Forms.Button infoButton;
        public System.Windows.Forms.PictureBox tiling;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button pidButton;
    }
}

