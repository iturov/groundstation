namespace ROV_GCS_V3
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.vSlider1 = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dockButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.missionPlannerPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.missionPlannerPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separator.LineThickness = 1;
            this.separator.Location = new System.Drawing.Point(345, 0);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(10, 800);
            this.separator.TabIndex = 0;
            this.separator.Transparency = 255;
            this.separator.Vertical = true;
            // 
            // vSlider1
            // 
            this.vSlider1.BackColor = System.Drawing.Color.Transparent;
            this.vSlider1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vSlider1.BorderRadius = 0;
            this.vSlider1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vSlider1.IndicatorColor = System.Drawing.Color.Gray;
            this.vSlider1.Location = new System.Drawing.Point(320, 50);
            this.vSlider1.MaximumValue = 100;
            this.vSlider1.Name = "vSlider1";
            this.vSlider1.Size = new System.Drawing.Size(30, 700);
            this.vSlider1.SliderRadius = 0;
            this.vSlider1.TabIndex = 12;
            this.vSlider1.Value = 0;
            this.vSlider1.ValueChanged += new System.EventHandler(this.vSlider1_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mission Planner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Image = global::ROV_GCS_V3.Properties.Resources.mission4;
            this.button1.Location = new System.Drawing.Point(438, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dockButton
            // 
            this.dockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dockButton.FlatAppearance.BorderSize = 0;
            this.dockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dockButton.ForeColor = System.Drawing.Color.White;
            this.dockButton.Image = ((System.Drawing.Image)(resources.GetObject("dockButton.Image")));
            this.dockButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dockButton.Location = new System.Drawing.Point(90, 760);
            this.dockButton.Name = "dockButton";
            this.dockButton.Size = new System.Drawing.Size(100, 40);
            this.dockButton.TabIndex = 16;
            this.dockButton.Text = "    Dock!";
            this.dockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dockButton.UseVisualStyleBackColor = false;
            this.dockButton.Click += new System.EventHandler(this.dockButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoButton.Location = new System.Drawing.Point(190, 760);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(160, 40);
            this.infoButton.TabIndex = 15;
            this.infoButton.Text = "    Information";
            this.infoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // missionPlannerPictureBox
            // 
            this.missionPlannerPictureBox.BackColor = System.Drawing.Color.Gray;
            this.missionPlannerPictureBox.ErrorImage = null;
            this.missionPlannerPictureBox.Location = new System.Drawing.Point(22, 14);
            this.missionPlannerPictureBox.Name = "missionPlannerPictureBox";
            this.missionPlannerPictureBox.Size = new System.Drawing.Size(275, 700);
            this.missionPlannerPictureBox.TabIndex = 14;
            this.missionPlannerPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 760);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "    Exit!";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.missionPlannerPictureBox);
            this.panel1.Location = new System.Drawing.Point(46, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 700);
            this.panel1.TabIndex = 18;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dockButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vSlider1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.separator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.LocationChanged += new System.EventHandler(this.Info_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Info_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Info_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.missionPlannerPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator separator;
        public System.Windows.Forms.Button exitButton;
        private Bunifu.Framework.UI.BunifuVTrackbar vSlider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox missionPlannerPictureBox;
        public System.Windows.Forms.Button infoButton;
        public System.Windows.Forms.Button dockButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}