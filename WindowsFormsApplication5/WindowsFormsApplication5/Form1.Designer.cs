namespace WindowsFormsApplication5
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
            this.camStatLabel = new System.Windows.Forms.Label();
            this.parameterspanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lightBar = new System.Windows.Forms.TrackBar();
            this.lightPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.artHorpanel2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artHorpanel = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.toptitlebar1 = new System.Windows.Forms.PictureBox();
            this.referanceTextJoy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.parameterspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artHorpanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artHorpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toptitlebar1)).BeginInit();
            this.SuspendLayout();
            // 
            // camStatLabel
            // 
            this.camStatLabel.AutoSize = true;
            this.camStatLabel.BackColor = System.Drawing.Color.Transparent;
            this.camStatLabel.ForeColor = System.Drawing.Color.White;
            this.camStatLabel.Location = new System.Drawing.Point(1072, 140);
            this.camStatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.camStatLabel.Name = "camStatLabel";
            this.camStatLabel.Size = new System.Drawing.Size(40, 17);
            this.camStatLabel.TabIndex = 9;
            this.camStatLabel.Text = "1234";
            // 
            // parameterspanel
            // 
            this.parameterspanel.Controls.Add(this.label8);
            this.parameterspanel.Controls.Add(this.referanceTextJoy);
            this.parameterspanel.Controls.Add(this.label7);
            this.parameterspanel.Controls.Add(this.comboBox2);
            this.parameterspanel.Controls.Add(this.label6);
            this.parameterspanel.Controls.Add(this.button2);
            this.parameterspanel.Controls.Add(this.textBox1);
            this.parameterspanel.Controls.Add(this.label5);
            this.parameterspanel.Controls.Add(this.label4);
            this.parameterspanel.Controls.Add(this.comboBox1);
            this.parameterspanel.Controls.Add(this.lightBar);
            this.parameterspanel.Controls.Add(this.lightPercent);
            this.parameterspanel.Controls.Add(this.label1);
            this.parameterspanel.Controls.Add(this.button1);
            this.parameterspanel.Controls.Add(this.label3);
            this.parameterspanel.Controls.Add(this.textBoxPort);
            this.parameterspanel.Controls.Add(this.label2);
            this.parameterspanel.Controls.Add(this.textBoxIP);
            this.parameterspanel.Location = new System.Drawing.Point(723, 266);
            this.parameterspanel.Margin = new System.Windows.Forms.Padding(4);
            this.parameterspanel.Name = "parameterspanel";
            this.parameterspanel.Size = new System.Drawing.Size(549, 674);
            this.parameterspanel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(124, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Controller Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DualShock2",
            "DualShock3"});
            this.comboBox2.Location = new System.Drawing.Point(240, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "DualShock2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "No Connection!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Connect!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 217);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "8092";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Start Server:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "DPI Scaling On/Off:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.comboBox1.Location = new System.Drawing.Point(240, 160);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lightBar
            // 
            this.lightBar.Location = new System.Drawing.Point(240, 82);
            this.lightBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lightBar.Name = "lightBar";
            this.lightBar.Size = new System.Drawing.Size(211, 56);
            this.lightBar.TabIndex = 17;
            this.lightBar.Scroll += new System.EventHandler(this.lightBar_Scroll);
            // 
            // lightPercent
            // 
            this.lightPercent.AutoSize = true;
            this.lightPercent.ForeColor = System.Drawing.Color.White;
            this.lightPercent.Location = new System.Drawing.Point(456, 102);
            this.lightPercent.Name = "lightPercent";
            this.lightPercent.Size = new System.Drawing.Size(28, 17);
            this.lightPercent.TabIndex = 16;
            this.lightPercent.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Light Intensity:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(352, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(399, 32);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(41, 22);
            this.textBoxPort.TabIndex = 11;
            this.textBoxPort.Text = "8091";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(153, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP Address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(240, 32);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(103, 22);
            this.textBoxIP.TabIndex = 9;
            this.textBoxIP.Text = "192.168.137.152";
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Location = new System.Drawing.Point(455, 55);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(4);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(132, 117);
            this.consoleBox.TabIndex = 11;
            this.consoleBox.Text = "";
            this.consoleBox.TextChanged += new System.EventHandler(this.consoleBox_TextChanged);
            this.consoleBox.MouseEnter += new System.EventHandler(this.consoleBox_MouseEnter);
            this.consoleBox.MouseLeave += new System.EventHandler(this.consoleBox_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // artHorpanel2
            // 
            this.artHorpanel2.Image = global::WindowsFormsApplication5.Properties.Resources.Comp_4_000001;
            this.artHorpanel2.Location = new System.Drawing.Point(440, 751);
            this.artHorpanel2.Margin = new System.Windows.Forms.Padding(4);
            this.artHorpanel2.Name = "artHorpanel2";
            this.artHorpanel2.Size = new System.Drawing.Size(1536, 651);
            this.artHorpanel2.TabIndex = 12;
            this.artHorpanel2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.paramtab_000003;
            this.pictureBox1.Location = new System.Drawing.Point(3, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 951);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // artHorpanel
            // 
            this.artHorpanel.Image = global::WindowsFormsApplication5.Properties.Resources.video_000001;
            this.artHorpanel.Location = new System.Drawing.Point(696, 126);
            this.artHorpanel.Margin = new System.Windows.Forms.Padding(4);
            this.artHorpanel.Name = "artHorpanel";
            this.artHorpanel.Size = new System.Drawing.Size(1280, 886);
            this.artHorpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.artHorpanel.TabIndex = 8;
            this.artHorpanel.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::WindowsFormsApplication5.Properties.Resources.Comp_2_00000_00000;
            this.closeButton.Location = new System.Drawing.Point(2349, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 59);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toptitlebar1
            // 
            this.toptitlebar1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toptitlebar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toptitlebar1.BackColor = System.Drawing.Color.Transparent;
            this.toptitlebar1.Image = global::WindowsFormsApplication5.Properties.Resources.Comp_1_000002;
            this.toptitlebar1.Location = new System.Drawing.Point(648, 15);
            this.toptitlebar1.Margin = new System.Windows.Forms.Padding(4);
            this.toptitlebar1.Name = "toptitlebar1";
            this.toptitlebar1.Size = new System.Drawing.Size(1423, 59);
            this.toptitlebar1.TabIndex = 0;
            this.toptitlebar1.TabStop = false;
            this.toptitlebar1.Click += new System.EventHandler(this.toptitlebar1_Click);
            // 
            // referanceTextJoy
            // 
            this.referanceTextJoy.AutoSize = true;
            this.referanceTextJoy.ForeColor = System.Drawing.Color.White;
            this.referanceTextJoy.Location = new System.Drawing.Point(384, 275);
            this.referanceTextJoy.Name = "referanceTextJoy";
            this.referanceTextJoy.Size = new System.Drawing.Size(46, 17);
            this.referanceTextJoy.TabIndex = 24;
            this.referanceTextJoy.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(268, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1924, 1084);
            this.ControlBox = false;
            this.Controls.Add(this.artHorpanel2);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parameterspanel);
            this.Controls.Add(this.camStatLabel);
            this.Controls.Add(this.artHorpanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toptitlebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1707, 886);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parameterspanel.ResumeLayout(false);
            this.parameterspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artHorpanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artHorpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toptitlebar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toptitlebar1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox artHorpanel;
        private System.Windows.Forms.Label camStatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel parameterspanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        public System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.TrackBar lightBar;
        private System.Windows.Forms.Label lightPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox artHorpanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label referanceTextJoy;
        private System.Windows.Forms.Label label8;
    }
}

