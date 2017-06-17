using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ROV_GCS_V3
{
    public class Variables
    {
        #region variables
        public bool leftPanelOpen = false;
        public bool connectionPanelOpen = false;
        public bool magnetState = false;
        public static int controllerType = 0; //1, d3 0 js
        public bool cameraState = false;
        public static bool connectionState = false;
        public static bool controllerStatus = false;
        public static string connectionStatus;
        public float currentMagnetDegree = 0;
        public Bitmap magnetBitmap = Properties.Resources.compass;
        #endregion variables

        public Variables()
        {

        }
    }
}
