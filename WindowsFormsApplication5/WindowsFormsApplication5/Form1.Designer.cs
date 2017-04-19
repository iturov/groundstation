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
            this.camStatLabel = new System.Windows.Forms.Label();
            this.parameterspanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artHorpanel = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.toptitlebar1 = new System.Windows.Forms.PictureBox();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.parameterspanel.SuspendLayout();
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
            this.camStatLabel.ForeColor = System.Drawing.Color.Black;
            this.camStatLabel.Location = new System.Drawing.Point(1072, 140);
            this.camStatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.camStatLabel.Name = "camStatLabel";
            this.camStatLabel.Size = new System.Drawing.Size(40, 17);
            this.camStatLabel.TabIndex = 9;
            this.camStatLabel.Text = "1234";
            // 
            // parameterspanel
            // 
            this.parameterspanel.Controls.Add(this.button1);
            this.parameterspanel.Controls.Add(this.label3);
            this.parameterspanel.Controls.Add(this.textBoxPort);
            this.parameterspanel.Controls.Add(this.label2);
            this.parameterspanel.Controls.Add(this.textBoxIP);
            this.parameterspanel.Location = new System.Drawing.Point(825, 266);
            this.parameterspanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parameterspanel.Name = "parameterspanel";
            this.parameterspanel.Size = new System.Drawing.Size(447, 675);
            this.parameterspanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(267, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(313, 14);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(41, 22);
            this.textBoxPort.TabIndex = 11;
            this.textBoxPort.Text = "8091";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP Address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(155, 14);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(103, 22);
            this.textBoxIP.TabIndex = 9;
            this.textBoxIP.Text = "192.168.2.127";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.paramtab_000003;
            this.pictureBox1.Location = new System.Drawing.Point(3, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 951);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // artHorpanel
            // 
            this.artHorpanel.Location = new System.Drawing.Point(753, 219);
            this.artHorpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artHorpanel.Name = "artHorpanel";
            this.artHorpanel.Size = new System.Drawing.Size(1280, 886);
            this.artHorpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.toptitlebar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toptitlebar1.Name = "toptitlebar1";
            this.toptitlebar1.Size = new System.Drawing.Size(1423, 59);
            this.toptitlebar1.TabIndex = 0;
            this.toptitlebar1.TabStop = false;
            this.toptitlebar1.Click += new System.EventHandler(this.toptitlebar1_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Location = new System.Drawing.Point(455, 55);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1924, 1084);
            this.ControlBox = false;
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parameterspanel);
            this.Controls.Add(this.camStatLabel);
            this.Controls.Add(this.artHorpanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toptitlebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1707, 886);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parameterspanel.ResumeLayout(false);
            this.parameterspanel.PerformLayout();
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
    }
}

