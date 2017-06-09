using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_GCS_V3
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        #region POSITIONING FROM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else
            {
                slide = !slide;
                dockUpdate(dock, false, slide);
            }
        }
        #endregion POSITIONING FROM

        Button[] missionButton = new Button[4];
        bool stateOpen = false;
        bool dock = true;
        bool slide = true;

        private void Info_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            updateFormSize(stateOpen);
            dockUpdate(dock, false, slide);
            this.Location = new Point(this.Location.X, 200);
            for (int i = 0; i < missionButton.Length; i++)
            {
                missionButton[i] = new Button();
                this.Controls.Add(missionButton[i]);
                missionButton[i].Size = new Size(40,40);
                missionButton[i].Location = new Point(0, 40 * (i + 1));
                missionButton[i].FlatStyle = FlatStyle.Flat;
                missionButton[i].FlatAppearance.BorderSize = 0;
                missionButton[i].BackColor = Color.FromArgb(255, 64, 64, 64);
                missionButton[i].Text = (i + 1).ToString();
                missionButton[i].Font = new Font("Microsoft Sans Serif", 15);
                missionButton[i].ForeColor = Color.White;
                missionButton[i].Name = "missionButton" + (i + 1).ToString();
                missionButton[i].MouseClick += missionButton_Click;
            }
            missionPlannerPictureBox.Parent = panel1;
            missionPlannerPictureBox.Location = new Point(0, 0);

        }

        private void missionButton_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            //"missionButton1", select 13-14 character which is 1"
            int btnNumber = Int16.Parse(bt.Name.Substring(13, 1));

            if (btnNumber == 1) missionPlannerPictureBox.Image = Properties.Resources.mission1;
            else missionPlannerPictureBox.Image = Properties.Resources.mission2;

            missionPlannerPictureBox.Size = new Size(missionPlannerPictureBox.Width, missionPlannerPictureBox.Image.Height);
            imageImported = true;
            missionPlannerPictureBox.Size = missionPlannerPictureBox.Image.Size;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFormSize(bool state)
        {
            if (state)
            {
                this.Size = new Size(700, this.Height);
            }
            else
            {
                this.Size = new Size(350, this.Height);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            stateOpen = !stateOpen;
            updateFormSize(stateOpen);
            dockUpdate(dock, false, slide);
        }

        private void dockButton_Click(object sender, EventArgs e)
        {
            dock = !dock;
            slide = true;
            dockUpdate(dock, true, slide);
        }

        private void dockUpdate(bool state, bool changed, bool state2)
        {

            if (state)
            {
                if(state2) this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
                else this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, this.Location.Y);
            }
            else
            {
                if (changed) this.Location = new Point(this.Location.X - 100, this.Location.Y);
            }


            //if (slide) this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, this.Location.Y);
            //else this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
        }

        private void Info_LocationChanged(object sender, EventArgs e)
        {
            dockUpdate(dock, false, slide);
        }


        private void Info_MouseUp(object sender, MouseEventArgs e)
        {
            //slide = false;
            //dockUpdate(dock, true, slide);
        }
        bool imageImported = false;
        private void vSlider1_ValueChanged(object sender, EventArgs e)
        {
            if (imageImported) missionPlannerPictureBox.Location = new Point(0, - (missionPlannerPictureBox.Image.Height - panel1.Height) * vSlider1.Value / 100);
        }
    }
}
