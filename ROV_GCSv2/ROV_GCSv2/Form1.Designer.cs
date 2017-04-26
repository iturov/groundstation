namespace ROV_GCSv2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cameraConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parametersPanel = new System.Windows.Forms.Panel();
            this.shutDownButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.distLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcpPortBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectController = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.joystickType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraPortBox = new System.Windows.Forms.TextBox();
            this.cameraIpBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.parametersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ROV_GCSv2.Properties.Resources._22_water_below_waterproof_cameras_630;
            this.pictureBox1.Location = new System.Drawing.Point(460, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cameraConnect
            // 
            this.cameraConnect.Location = new System.Drawing.Point(255, 11);
            this.cameraConnect.Name = "cameraConnect";
            this.cameraConnect.Size = new System.Drawing.Size(87, 51);
            this.cameraConnect.TabIndex = 1;
            this.cameraConnect.Text = "Connect Camera";
            this.cameraConnect.UseVisualStyleBackColor = true;
            this.cameraConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parametersPanel
            // 
            this.parametersPanel.Controls.Add(this.shutDownButton);
            this.parametersPanel.Controls.Add(this.connectionStatusLabel);
            this.parametersPanel.Controls.Add(this.serialLabel);
            this.parametersPanel.Controls.Add(this.distLabel);
            this.parametersPanel.Controls.Add(this.tempLabel);
            this.parametersPanel.Controls.Add(this.depthLabel);
            this.parametersPanel.Controls.Add(this.pressureLabel);
            this.parametersPanel.Controls.Add(this.label10);
            this.parametersPanel.Controls.Add(this.label9);
            this.parametersPanel.Controls.Add(this.label8);
            this.parametersPanel.Controls.Add(this.label7);
            this.parametersPanel.Controls.Add(this.label6);
            this.parametersPanel.Controls.Add(this.label5);
            this.parametersPanel.Controls.Add(this.tcpPortBox);
            this.parametersPanel.Controls.Add(this.button1);
            this.parametersPanel.Controls.Add(this.throttleLabel);
            this.parametersPanel.Controls.Add(this.label4);
            this.parametersPanel.Controls.Add(this.connectController);
            this.parametersPanel.Controls.Add(this.label3);
            this.parametersPanel.Controls.Add(this.joystickType);
            this.parametersPanel.Controls.Add(this.label2);
            this.parametersPanel.Controls.Add(this.label1);
            this.parametersPanel.Controls.Add(this.cameraConnect);
            this.parametersPanel.Controls.Add(this.cameraPortBox);
            this.parametersPanel.Controls.Add(this.cameraIpBox);
            this.parametersPanel.Location = new System.Drawing.Point(71, 36);
            this.parametersPanel.Name = "parametersPanel";
            this.parametersPanel.Size = new System.Drawing.Size(364, 426);
            this.parametersPanel.TabIndex = 3;
            // 
            // shutDownButton
            // 
            this.shutDownButton.Location = new System.Drawing.Point(255, 359);
            this.shutDownButton.Name = "shutDownButton";
            this.shutDownButton.Size = new System.Drawing.Size(87, 51);
            this.shutDownButton.TabIndex = 0;
            this.shutDownButton.Text = "Close";
            this.shutDownButton.UseVisualStyleBackColor = true;
            this.shutDownButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.White;
            this.connectionStatusLabel.Location = new System.Drawing.Point(76, 209);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(125, 17);
            this.connectionStatusLabel.TabIndex = 26;
            this.connectionStatusLabel.Text = "-connectionstatus-";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.ForeColor = System.Drawing.Color.White;
            this.serialLabel.Location = new System.Drawing.Point(136, 359);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(66, 17);
            this.serialLabel.TabIndex = 25;
            this.serialLabel.Text = "-serdata-";
            // 
            // distLabel
            // 
            this.distLabel.AutoSize = true;
            this.distLabel.ForeColor = System.Drawing.Color.White;
            this.distLabel.Location = new System.Drawing.Point(136, 325);
            this.distLabel.Name = "distLabel";
            this.distLabel.Size = new System.Drawing.Size(40, 17);
            this.distLabel.TabIndex = 24;
            this.distLabel.Text = "-dist-";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(136, 295);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(49, 17);
            this.tempLabel.TabIndex = 23;
            this.tempLabel.Text = "-temp-";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.ForeColor = System.Drawing.Color.White;
            this.depthLabel.Location = new System.Drawing.Point(136, 266);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(54, 17);
            this.depthLabel.TabIndex = 22;
            this.depthLabel.Text = "-depth-";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.ForeColor = System.Drawing.Color.White;
            this.pressureLabel.Location = new System.Drawing.Point(136, 239);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(74, 17);
            this.pressureLabel.TabIndex = 21;
            this.pressureLabel.Text = "-pressure-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Serial Data: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(59, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Distance: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Temperature: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Depth: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pressure: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "TCP Listening Port: ";
            // 
            // tcpPortBox
            // 
            this.tcpPortBox.Location = new System.Drawing.Point(171, 173);
            this.tcpPortBox.Name = "tcpPortBox";
            this.tcpPortBox.Size = new System.Drawing.Size(39, 22);
            this.tcpPortBox.TabIndex = 14;
            this.tcpPortBox.Text = "8092";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect TCP/IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.ForeColor = System.Drawing.Color.White;
            this.throttleLabel.Location = new System.Drawing.Point(130, 131);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(96, 17);
            this.throttleLabel.TabIndex = 12;
            this.throttleLabel.Text = "-throttlevalue-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Throttle Value: ";
            // 
            // connectController
            // 
            this.connectController.Location = new System.Drawing.Point(255, 90);
            this.connectController.Name = "connectController";
            this.connectController.Size = new System.Drawing.Size(87, 58);
            this.connectController.TabIndex = 10;
            this.connectController.Text = "Connect Controller";
            this.connectController.UseVisualStyleBackColor = true;
            this.connectController.Click += new System.EventHandler(this.connectController_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Controller Type: ";
            // 
            // joystickType
            // 
            this.joystickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.joystickType.FormattingEnabled = true;
            this.joystickType.Items.AddRange(new object[] {
            "DualShock 2",
            "DualShock 3"});
            this.joystickType.Location = new System.Drawing.Point(133, 90);
            this.joystickType.Name = "joystickType";
            this.joystickType.Size = new System.Drawing.Size(116, 24);
            this.joystickType.TabIndex = 8;
            this.joystickType.SelectedIndexChanged += new System.EventHandler(this.joystickType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Camera Stream Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camera Stream IP:";
            // 
            // cameraPortBox
            // 
            this.cameraPortBox.Location = new System.Drawing.Point(210, 40);
            this.cameraPortBox.Name = "cameraPortBox";
            this.cameraPortBox.Size = new System.Drawing.Size(39, 22);
            this.cameraPortBox.TabIndex = 5;
            this.cameraPortBox.Text = "8091";
            // 
            // cameraIpBox
            // 
            this.cameraIpBox.Location = new System.Drawing.Point(149, 12);
            this.cameraIpBox.Name = "cameraIpBox";
            this.cameraIpBox.Size = new System.Drawing.Size(100, 22);
            this.cameraIpBox.TabIndex = 4;
            this.cameraIpBox.Text = "192.168.131.69";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1059, 474);
            this.Controls.Add(this.parametersPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.parametersPanel.ResumeLayout(false);
            this.parametersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cameraConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel parametersPanel;
        private System.Windows.Forms.Button shutDownButton;
        private System.Windows.Forms.TextBox cameraIpBox;
        private System.Windows.Forms.TextBox cameraPortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox joystickType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label throttleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcpPortBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label distLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label connectionStatusLabel;
    }
}

