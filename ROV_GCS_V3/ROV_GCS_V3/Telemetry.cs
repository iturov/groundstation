using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using rtChart;

namespace ROV_GCS_V3
{
    public partial class Telemetry : Form
    {
        /*
        public struct Telemetric
        {
            public string ItemType { get; set; }
            public int ItemIndex { get; set; }
            public string ItemName { get; set; }
            public Telemetric(string type, string name, int index)
            {
                this.ItemIndex = index;
                this.ItemType = type;
                this.ItemName = name;
            }

            public override string ToString()
            {
                return this.ItemName;
            }
        }

        List<Telemetric> Telemetrics = new List<Telemetric>();     
        
        public void populate()
        {
            /// parça 1, init içine yaz
            Telemetrics.Add(new Telemetric("myarray1", "YAW", 4 ));
            Telemetrics.Add(new Telemetric("myarray2", "Pitch", 2 ));
            Telemetrics.Add(new Telemetric("myarray3", "Speed", 123 ));
            
            /// formu yüklerken 
            ComboBox cm = new ComboBox();
            foreach(Telemetric s in Telemetrics)
                cm.Items.Add(s);
            /// 

            Telemetric t = ((Telemetric)cm.SelectedItem);
            if (t.ItemType == "mytype1")
                return myarray1[t.ItemIndex];
            else if (t.ItemType == "mytype2")
                return myarray2[t.ItemIndex];
        }
        */

        #region POSITIONING FROM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Telemetry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion POSITIONING FROM

        public Telemetry()
        {
            InitializeComponent();
            graph1 = new kayChart(chart1, 60);
            graph2 = new kayChart(chart2, 60);
            graph3 = new kayChart(chart3, 60);
        }

        kayChart graph1;
        kayChart graph2;
        kayChart graph3;
        int[] telemetric = new int[16];

        private static int mapInt(int value, int currentMin, int currentMax, int targetMin, int targetMax, int reverse = 0)
        {
            int st1, st2;
            if (reverse == 1)
            {
                st1 = currentMin;
                st2 = currentMax;
                currentMin = st2;
                currentMax = st1;
            }

            int range = (currentMax - currentMin);
            int rangeT = targetMax - targetMin;
            value = (value - currentMin) * rangeT / range + targetMin;
            return value;
        }

        private void Telemetry_Load(object sender, EventArgs e)
        {
            dockbutton.Location = new Point(this.Width - closebutton.Width - dockbutton.Width, this.Height - dockbutton.Height);
            closebutton.Location = new Point(this.Width - closebutton.Width, this.Height - dockbutton.Height);
            closebutton.Text = "Close!";
            dockbutton.Text = "Dock Tab!";
            progressBar1.Location = new Point(chart1.Width, 0);
            this.TopMost = true;
        }

        private void chart1_combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            updateVariables();

            graph1.TriggeredUpdate(Int32.Parse(Vehicle.dataSent[0]));
            progressBar1.Value = mapInt(Int32.Parse(Vehicle.dataSent[0]), -350, 350, -100, 100);

            graph2.TriggeredUpdate(Controller.controllerData[2]);
            progressBar2.Value = mapInt(Controller.controllerData[2], -150, 150, -100, 100);

            graph3.TriggeredUpdate(Controller.controllerData[4]);
            progressBar3.Value = mapInt(Controller.controllerData[4], -400, 400, -100, 100);
        }
        
        private void updateVariables()
        {
            telemetric[0] = Int32.Parse(Vehicle.dataSent[0]); // THROTTLE
            telemetric[1] = Int32.Parse(Vehicle.dataSent[0]); // 
            telemetric[2] = Int32.Parse(Vehicle.dataSent[0]);
            telemetric[3] = Int32.Parse(Vehicle.dataSent[0]);
            telemetric[4] = Int32.Parse(Vehicle.dataSent[0]);
            //...
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
        }
        bool state = false;

        private void Telemetry_LocationChanged(object sender, EventArgs e)
        {
            if(state) this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
        }

        private void dockbutton_Click_1(object sender, EventArgs e)
        {
            state = !state;
            if (state)
            {
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
                dockbutton.Image = Properties.Resources.minimizeIcon;
                dockbutton.Text = "Undock Tab!";
            }
            else
            {
                dockbutton.Image = Properties.Resources.maximizeIcon;
                dockbutton.Text = "Dock Tab!";
            }

            
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}