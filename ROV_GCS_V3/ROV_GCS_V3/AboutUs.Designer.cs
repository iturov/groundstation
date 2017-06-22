namespace ROV_GCS_V3
{
    partial class AboutUs
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
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutUsLabel
            // 
            this.aboutUsLabel.AutoSize = true;
            this.aboutUsLabel.ForeColor = System.Drawing.Color.White;
            this.aboutUsLabel.Location = new System.Drawing.Point(138, 438);
            this.aboutUsLabel.Name = "aboutUsLabel";
            this.aboutUsLabel.Size = new System.Drawing.Size(73, 13);
            this.aboutUsLabel.TabIndex = 2;
            this.aboutUsLabel.Text = "-aboutuslabel-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ROV_GCS_V3.Properties.Resources.itu_logo;
            this.pictureBox2.Location = new System.Drawing.Point(574, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::ROV_GCS_V3.Properties.Resources.Close_Window_32px;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitButton.Location = new System.Drawing.Point(628, 575);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "    Exit!";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROV_GCS_V3.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(141, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(753, 615);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aboutUsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label aboutUsLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}