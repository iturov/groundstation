using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROV_GCS_V3
{
    public class Variables
    {
        #region variables
        public bool leftPanelOpen = false;
        public bool connectionPanelOpen = false;
        public static int controllerType = 0; //0, d3 1 d2
        public bool cameraState = false;
        public static string controllerStatus;
        public static string connectionStatus;
        #endregion variables

        public Variables()
        {

        }
    }
}
