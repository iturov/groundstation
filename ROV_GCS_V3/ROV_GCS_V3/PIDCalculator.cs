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
    public partial class PIDCalculator : Form
    {

        #region POSITIONING FROM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PIDCalculator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion POSITIONING FROM

        public PIDCalculator()
        {
            InitializeComponent();
        }

        public float Kp, Ki, Kd;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void derivativeSlider_Scroll(object sender, EventArgs e)
        {
            Kd = (float)derivativeSlider.Value / 20.0f;
            dLabel.Text = Kd.ToString();
        }

        private void PIDCalculator_Load(object sender, EventArgs e)
        {
            exitButton.Location = new Point(this.Width - exitButton.Width, this.Height - exitButton.Height);
        }

        private void proportionalSlider_Scroll(object sender, EventArgs e)
        {
            Kp = (float)proportionalSlider.Value / 20.0f;
            pLabel.Text = Kp.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Ki = (float)integralSlider.Value / 20.0f;
            iLabel.Text = Ki.ToString();
        }
    }
}
