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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telemetry));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closebutton = new System.Windows.Forms.Button();
            this.dockbutton = new System.Windows.Forms.Button();
            this.progressBar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressBar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(460, 120);
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
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 120);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(460, 120);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 240);
            this.chart3.Name = "chart3";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(460, 120);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closebutton.Location = new System.Drawing.Point(687, 320);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(100, 40);
            this.closebutton.TabIndex = 13;
            this.closebutton.Text = "    Minimize!";
            this.closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // dockbutton
            // 
            this.dockbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dockbutton.FlatAppearance.BorderSize = 0;
            this.dockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dockbutton.ForeColor = System.Drawing.Color.White;
            this.dockbutton.Image = ((System.Drawing.Image)(resources.GetObject("dockbutton.Image")));
            this.dockbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dockbutton.Location = new System.Drawing.Point(582, 320);
            this.dockbutton.Name = "dockbutton";
            this.dockbutton.Size = new System.Drawing.Size(100, 40);
            this.dockbutton.TabIndex = 12;
            this.dockbutton.Text = "    Minimize!";
            this.dockbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dockbutton.UseVisualStyleBackColor = false;
            this.dockbutton.Click += new System.EventHandler(this.dockbutton_Click_1);
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
            this.progressBar3.Location = new System.Drawing.Point(460, 240);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.MaxValue = 100;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar3.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar3.Size = new System.Drawing.Size(110, 110);
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Value = 50;
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
            this.progressBar2.Location = new System.Drawing.Point(460, 120);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.MaxValue = 100;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar2.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar2.Size = new System.Drawing.Size(110, 110);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Value = 50;
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
            this.progressBar1.Location = new System.Drawing.Point(460, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar1.Size = new System.Drawing.Size(110, 110);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // Telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(787, 360);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.dockbutton);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Telemetry";
            this.Text = "Telemetry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Telemetry_FormClosing);
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
        public System.Windows.Forms.Button dockbutton;
        public System.Windows.Forms.Button closebutton;
    }
}