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
            this.lightBar = new System.Windows.Forms.TrackBar();
            this.lightPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.artHorpanel2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artHorpanel = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.toptitlebar1 = new System.Windows.Forms.PictureBox();
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
            this.camStatLabel.Location = new System.Drawing.Point(804, 114);
            this.camStatLabel.Name = "camStatLabel";
            this.camStatLabel.Size = new System.Drawing.Size(31, 13);
            this.camStatLabel.TabIndex = 9;
            this.camStatLabel.Text = "1234";
            // 
            // parameterspanel
            // 
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
            this.parameterspanel.Location = new System.Drawing.Point(542, 216);
            this.parameterspanel.Name = "parameterspanel";
            this.parameterspanel.Size = new System.Drawing.Size(412, 548);
            this.parameterspanel.TabIndex = 6;
            // 
            // lightBar
            // 
            this.lightBar.Location = new System.Drawing.Point(180, 67);
            this.lightBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lightBar.Name = "lightBar";
            this.lightBar.Size = new System.Drawing.Size(158, 45);
            this.lightBar.TabIndex = 17;
            this.lightBar.Scroll += new System.EventHandler(this.lightBar_Scroll);
            // 
            // lightPercent
            // 
            this.lightPercent.AutoSize = true;
            this.lightPercent.ForeColor = System.Drawing.Color.White;
            this.lightPercent.Location = new System.Drawing.Point(342, 83);
            this.lightPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lightPercent.Name = "lightPercent";
            this.lightPercent.Size = new System.Drawing.Size(21, 13);
            this.lightPercent.TabIndex = 16;
            this.lightPercent.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Light Intensity:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(264, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(299, 26);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(32, 20);
            this.textBoxPort.TabIndex = 11;
            this.textBoxPort.Text = "8091";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(115, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP Address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(180, 26);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(78, 20);
            this.textBoxIP.TabIndex = 9;
            this.textBoxIP.Text = "192.168.137.152";
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Location = new System.Drawing.Point(341, 45);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(100, 96);
            this.consoleBox.TabIndex = 11;
            this.consoleBox.Text = "";
            this.consoleBox.TextChanged += new System.EventHandler(this.consoleBox_TextChanged);
            this.consoleBox.MouseEnter += new System.EventHandler(this.consoleBox_MouseEnter);
            this.consoleBox.MouseLeave += new System.EventHandler(this.consoleBox_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.comboBox1.Location = new System.Drawing.Point(180, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DPI Scaling On/Off:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Start Server:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "8092";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Connect!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(288, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "No Connection!";
            // 
            // artHorpanel2
            // 
            this.artHorpanel2.Image = global::WindowsFormsApplication5.Properties.Resources.Comp_4_000001;
            this.artHorpanel2.Location = new System.Drawing.Point(401, 333);
            this.artHorpanel2.Name = "artHorpanel2";
            this.artHorpanel2.Size = new System.Drawing.Size(1152, 529);
            this.artHorpanel2.TabIndex = 12;
            this.artHorpanel2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.paramtab_000003;
            this.pictureBox1.Location = new System.Drawing.Point(2, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 773);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // artHorpanel
            // 
            this.artHorpanel.Image = global::WindowsFormsApplication5.Properties.Resources.video_000001;
            this.artHorpanel.Location = new System.Drawing.Point(522, 102);
            this.artHorpanel.Name = "artHorpanel";
            this.artHorpanel.Size = new System.Drawing.Size(960, 720);
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
            this.closeButton.Location = new System.Drawing.Point(1762, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(48, 48);
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
            this.toptitlebar1.Location = new System.Drawing.Point(486, 12);
            this.toptitlebar1.Name = "toptitlebar1";
            this.toptitlebar1.Size = new System.Drawing.Size(1067, 48);
            this.toptitlebar1.TabIndex = 0;
            this.toptitlebar1.TabStop = false;
            this.toptitlebar1.Click += new System.EventHandler(this.toptitlebar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1443, 881);
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
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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
    }
}

