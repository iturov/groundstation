namespace ROV_GCS_V3
{
    partial class PIDCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIDCalculator));
            this.pLabel = new System.Windows.Forms.Label();
            this.iLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.proportionalSlider = new System.Windows.Forms.TrackBar();
            this.integralSlider = new System.Windows.Forms.TrackBar();
            this.derivativeSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.proportionalSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivativeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.White;
            this.pLabel.Location = new System.Drawing.Point(594, 12);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(71, 25);
            this.pLabel.TabIndex = 4;
            this.pLabel.Text = "pLabel";
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel.ForeColor = System.Drawing.Color.White;
            this.iLabel.Location = new System.Drawing.Point(587, 65);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(64, 25);
            this.iLabel.TabIndex = 5;
            this.iLabel.Text = "iLabel";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.White;
            this.dLabel.Location = new System.Drawing.Point(587, 125);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(71, 25);
            this.dLabel.TabIndex = 6;
            this.dLabel.Text = "dLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(545, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(545, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kd:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitButton.Location = new System.Drawing.Point(665, 147);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 45);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "    Exit!";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // proportionalSlider
            // 
            this.proportionalSlider.Location = new System.Drawing.Point(12, 12);
            this.proportionalSlider.Maximum = 100;
            this.proportionalSlider.Name = "proportionalSlider";
            this.proportionalSlider.Size = new System.Drawing.Size(537, 56);
            this.proportionalSlider.TabIndex = 11;
            this.proportionalSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.proportionalSlider.Scroll += new System.EventHandler(this.proportionalSlider_Scroll);
            // 
            // integralSlider
            // 
            this.integralSlider.Location = new System.Drawing.Point(12, 65);
            this.integralSlider.Maximum = 100;
            this.integralSlider.Name = "integralSlider";
            this.integralSlider.Size = new System.Drawing.Size(537, 56);
            this.integralSlider.TabIndex = 12;
            this.integralSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.integralSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // derivativeSlider
            // 
            this.derivativeSlider.Location = new System.Drawing.Point(12, 125);
            this.derivativeSlider.Maximum = 100;
            this.derivativeSlider.Name = "derivativeSlider";
            this.derivativeSlider.Size = new System.Drawing.Size(537, 56);
            this.derivativeSlider.TabIndex = 13;
            this.derivativeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.derivativeSlider.Scroll += new System.EventHandler(this.derivativeSlider_Scroll);
            // 
            // PIDCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(793, 193);
            this.Controls.Add(this.derivativeSlider);
            this.Controls.Add(this.integralSlider);
            this.Controls.Add(this.proportionalSlider);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.iLabel);
            this.Controls.Add(this.pLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PIDCalculator";
            this.Text = "PIDCalculator";
            this.Load += new System.EventHandler(this.PIDCalculator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PIDCalculator_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.proportionalSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivativeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TrackBar proportionalSlider;
        private System.Windows.Forms.TrackBar integralSlider;
        private System.Windows.Forms.TrackBar derivativeSlider;
    }
}