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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telemetry));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea13.AxisX.LabelStyle.Enabled = false;
            chartArea13.AxisX.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.MajorGrid.Enabled = false;
            chartArea13.AxisX.MajorTickMark.Enabled = false;
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisY.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea13.AxisY.MajorTickMark.Enabled = false;
            chartArea13.BackColor = System.Drawing.Color.Transparent;
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.RoyalBlue;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
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
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.progressBar1.Size = new System.Drawing.Size(110, 110);
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
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea14.AxisX.LabelStyle.Enabled = false;
            chartArea14.AxisX.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.MajorGrid.Enabled = false;
            chartArea14.AxisX.MajorTickMark.Enabled = false;
            chartArea14.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisY.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea14.AxisY.MajorTickMark.Enabled = false;
            chartArea14.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(0, 120);
            this.chart2.Name = "chart2";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.RoyalBlue;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(460, 120);
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
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea15.AxisX.LabelStyle.Enabled = false;
            chartArea15.AxisX.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.MajorGrid.Enabled = false;
            chartArea15.AxisX.MajorTickMark.Enabled = false;
            chartArea15.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea15.AxisY.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea15.AxisY.MajorTickMark.Enabled = false;
            chartArea15.BackColor = System.Drawing.Color.Transparent;
            chartArea15.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea15);
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.chart3.Legends.Add(legend15);
            this.chart3.Location = new System.Drawing.Point(0, 240);
            this.chart3.Name = "chart3";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.RoyalBlue;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(460, 120);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(570, 0);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 7;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(570, 120);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown2.TabIndex = 8;
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown3.BorderRadius = 3;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown3.Items = new string[0];
            this.bunifuDropdown3.Location = new System.Drawing.Point(570, 240);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown3.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown3.selectedIndex = -1;
            this.bunifuDropdown3.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown3.TabIndex = 9;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Dock Tab";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(570, 312);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(217, 48);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Dock Tab";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(787, 360);
            this.Controls.Add(this.bunifuFlatButton1);
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}