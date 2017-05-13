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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }
        public string aboutUsText = "HELLO WORLD! \n Enter Text Here!";
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            pictureBox1.Location = new Point((this.Width - pictureBox1.Width) / 2, 0);
            aboutUsLabel.Text = aboutUsText;
            aboutUsLabel.Location = new Point((this.Size.Width - aboutUsLabel.Size.Width) / 2, aboutUsLabel.Location.Y);
        }
    }
}
