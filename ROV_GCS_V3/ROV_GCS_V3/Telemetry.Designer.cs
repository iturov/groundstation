namespace ROV_GCS_V3
{
    partial class Telemetry
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telemetry));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressBar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dockbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.RoyalBlue;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(613, 148);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            // 
            // refresher
            // 
            this.refresher.Enabled = true;
            this.refresher.Interval = 70;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.animated = false;
            this.progressBar1.animationIterval = 5;
            this.progressBar1.animationSpeed = 300;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar1.BackgroundImage")));
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.progressBar1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.progressBar1.LabelVisible = true;
            this.progressBar1.LineProgressThickness = 3;
            this.progressBar1.LineThickness = 2;
            this.progressBar1.Location = new System.Drawing.Point(613, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar1.Size = new System.Drawing.Size(135, 135);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // progressBar2
            // 
            this.progressBar2.animated = false;
            this.progressBar2.animationIterval = 5;
            this.progressBar2.animationSpeed = 300;
            this.progressBar2.BackColor = System.Drawing.Color.Transparent;
            this.progressBar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar2.BackgroundImage")));
            this.progressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.progressBar2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.progressBar2.LabelVisible = true;
            this.progressBar2.LineProgressThickness = 3;
            this.progressBar2.LineThickness = 2;
            this.progressBar2.Location = new System.Drawing.Point(613, 148);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar2.MaxValue = 100;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar2.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar2.Size = new System.Drawing.Size(135, 135);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Value = 50;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.Enabled = false;
            chartArea8.AxisX.MajorTickMark.Enabled = false;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(0, 148);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.RoyalBlue;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(613, 148);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // progressBar3
            // 
            this.progressBar3.animated = false;
            this.progressBar3.animationIterval = 5;
            this.progressBar3.animationSpeed = 300;
            this.progressBar3.BackColor = System.Drawing.Color.Transparent;
            this.progressBar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar3.BackgroundImage")));
            this.progressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.progressBar3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.progressBar3.LabelVisible = true;
            this.progressBar3.LineProgressThickness = 3;
            this.progressBar3.LineThickness = 2;
            this.progressBar3.Location = new System.Drawing.Point(613, 295);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar3.MaxValue = 100;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar3.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar3.Size = new System.Drawing.Size(135, 135);
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Value = 50;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.LabelStyle.Enabled = false;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX.MajorTickMark.Enabled = false;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea9.AxisY.MajorTickMark.Enabled = false;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(0, 295);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.RoyalBlue;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(613, 148);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(760, 0);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(289, 43);
            this.bunifuDropdown1.TabIndex = 7;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(760, 148);
            this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(289, 43);
            this.bunifuDropdown2.TabIndex = 8;
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown3.BorderRadius = 3;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown3.Items = new string[0];
            this.bunifuDropdown3.Location = new System.Drawing.Point(760, 295);
            this.bunifuDropdown3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown3.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown3.selectedIndex = -1;
            this.bunifuDropdown3.Size = new System.Drawing.Size(289, 43);
            this.bunifuDropdown3.TabIndex = 9;
            // 
            // dockbutton
            // 
            this.dockbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dockbutton.FlatAppearance.BorderSize = 0;
            this.dockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dockbutton.ForeColor = System.Drawing.Color.White;
            this.dockbutton.Image = ((System.Drawing.Image)(resources.GetObject("dockbutton.Image")));
            this.dockbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dockbutton.Location = new System.Drawing.Point(776, 394);
            this.dockbutton.Margin = new System.Windows.Forms.Padding(4);
            this.dockbutton.Name = "dockbutton";
            this.dockbutton.Size = new System.Drawing.Size(133, 49);
            this.dockbutton.TabIndex = 12;
            this.dockbutton.Text = "    Minimize!";
            this.dockbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dockbutton.UseVisualStyleBackColor = false;
            this.dockbutton.Click += new System.EventHandler(this.dockbutton_Click_1);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Image = global::ROV_GCS_V3.Properties.Resources.Close_Window_32px;
            this.closebutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closebutton.Location = new System.Drawing.Point(916, 394);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(133, 49);
            this.closebutton.TabIndex = 13;
            this.closebutton.Text = "    Minimize!";
            this.closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1049, 443);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.dockbutton);
            this.Controls.Add(this.bunifuDropdown3);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Telemetry";
            this.Text = "Telemetry";
            this.Load += new System.EventHandler(this.Telemetry_Load);
            this.LocationChanged += new System.EventHandler(this.Telemetry_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Telemetry_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer refresher;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown3;
        public System.Windows.Forms.Button dockbutton;
        public System.Windows.Forms.Button closebutton;
    }
}