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
using System.IO;

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

            graph[0] = new kayChart(chart1, 60);
            graph[1] = new kayChart(chart2, 60);
            graph[2] = new kayChart(chart3, 60);
            addListItems();
            for (int i = 0; i < dropdown.Length; i++)
            {
                strm[i] = new StreamWriter("text" + i.ToString() + ".txt");

                chechBoxState[i] = false;
                ch[i] = new CheckBox();
                this.Controls.Add(ch[i]);
                ch[i].Location = new Point(570, i * 120 + 40);
                ch[i].Name = i.ToString();
                ch[i].Text = "Start Logging";
                ch[i].CheckedChanged += checkBoxCheckedEvent;
                ch[i].ForeColor = System.Drawing.Color.White;

                dropdown[i] = new Bunifu.Framework.UI.BunifuDropdown();
                this.Controls.Add(dropdown[i]);
                dropdown[i].Size = new Size(217, 35);
                dropdown[i].Location = new Point(570, i * 120);
                dropdown[i].Name = i.ToString();
                dropdown[i].onHoverColor = System.Drawing.Color.DarkGray;
                dropdown[i].NomalColor = System.Drawing.Color.Gray;
                dropdown[i].onItemSelected += selectedEvent;
                for (int k = 0; k < dropList.Length; k++)
                {
                    dropdown[i].AddItem(dropList[k]);
                }
                dropdown[i].selectedIndex = 0;
                
            }
        }
        Bunifu.Framework.UI.BunifuDropdown[] dropdown = new Bunifu.Framework.UI.BunifuDropdown[3];
        kayChart[] graph = new kayChart[3];
        CheckBox[] ch = new CheckBox[3];
        bool[] selectedState = new bool[3];
        int[] telemetric = new int[16];
        int[] telemetricRange = {350 / 3, 400 / 3, 400 / 3, 200 / 3, 1200, 500, 50, 2000, 100, 100, 100, 100, 100, 100, 100, 100};
        int[] selectedIndexList = new int[3];
        string[] dropList = new string[16];
        bool[] chechBoxState = new bool[3];
        StreamWriter[] strm = new StreamWriter[3];

        private int constrain(int value, int min, int max)
        {
            if (value > max) value = max;
            if (value < min) value = min;
            return value;
        }

        private void checkBoxCheckedEvent(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            int stateNumber = Int16.Parse(ch.Name);
            chechBoxState[stateNumber] = !chechBoxState[stateNumber];
        }

        private void selectedEvent(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuDropdown drop = (Bunifu.Framework.UI.BunifuDropdown)sender;
            selectedState[Int16.Parse(drop.Name)] = true;
            if (!chechBoxState[Int16.Parse(drop.Name)]) strm[Int16.Parse(drop.Name)].WriteLine("END OF STREAM");
        }

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

        private void refresher_Tick(object sender, EventArgs e)
        {
            if (Variables.controllerStatus)
            {
                updateVariables();

                for (int i = 0; i < graph.Length; i++)
                {
                    selectedIndexList[i] = 0;
                    if (selectedState[i]) selectedIndexList[i] = dropdown[i].selectedIndex;
                    int k = telemetric[selectedIndexList[i]];
                    graph[i].TriggeredUpdate(k);

                    for (int c = 0; c < 3; c++)
                    {
                        if (chechBoxState[c]) strm[c].WriteLine(k.ToString());
                        //else strm[c].WriteLine("END OF STREAM");
                    }
                }
                for (int i = 0; i < telemetric.Length; i++)
                {
                    telemetric[i] = constrain(telemetric[i], -telemetricRange[i], telemetricRange[i]);
                }
                
                progressBar1.Value = mapInt(telemetric[selectedIndexList[0]], -telemetricRange[selectedIndexList[0]], telemetricRange[selectedIndexList[0]], -100, 100);
                progressBar2.Value = mapInt(telemetric[selectedIndexList[1]], -telemetricRange[selectedIndexList[1]], telemetricRange[selectedIndexList[1]], -100, 100);
                progressBar3.Value = mapInt(telemetric[selectedIndexList[2]], -telemetricRange[selectedIndexList[2]], telemetricRange[selectedIndexList[2]], -100, 100);
            }
        }
        
        private void addListItems()
        {
            dropList[0] = "Throttle";
            dropList[1] = "Y-Axis";
            dropList[2] = "X-Axis";
            dropList[3] = "Yaw";
            dropList[4] = "Pressure";
            dropList[5] = "Depth";
            dropList[6] = "Temperature";
            dropList[7] = "Arduino";
            dropList[8] = "Throttle";
            dropList[9] = "Throttle";
            dropList[10] = "Throttle";
            dropList[11] = "Throttle";
            dropList[12] = "Throttle";
            dropList[13] = "Throttle";
            dropList[14] = "Throttle";
            dropList[15] = "Throttle";
        }

        private void updateVariables()
        {
            for (int i = 0; i < telemetric.Length; i++)
            {
                telemetric[i] = 0;
            }
            telemetric[0] = Controller.controllerData[3]; // THROTTLE
            telemetric[1] = Controller.controllerData[5]; // foward/back
            telemetric[2] = Controller.controllerData[4]; // left/Right
            telemetric[3] = Controller.controllerData[16]; // yaw
            if (!(Vehicle.dataReceived == null))
            {
                if (!(Vehicle.dataReceived[0] == null))  telemetric[4] = (int)float.Parse(Vehicle.dataReceived[0]); // pressure
                if (!(Vehicle.dataReceived[1] == null))  telemetric[5] = (int)(float.Parse(Vehicle.dataReceived[1]) * 100); // depth
                if (!(Vehicle.dataReceived[2] == null))  telemetric[6] = (int)float.Parse(Vehicle.dataReceived[2]); // temperature
                try { if (!(Vehicle.dataReceived[3] == null)) telemetric[7] = (int)float.Parse(Vehicle.dataReceived[3]); }// arduino
                catch (Exception parseEcxeption) { MessageBox.Show(parseEcxeption.ToString()); }
                //arduino data can be string, converting to float may fail
            }
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

        private void Telemetry_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}