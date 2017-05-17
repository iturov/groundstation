using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_GCS_V3
{
    class Controller
    {
        #region variables
        public static int[] controllerData = new int[32];
        BackgroundWorker getController = new BackgroundWorker();
        Form1 form;
        #endregion variables

        #region privateFunctions
        public Controller(Form1 form)
        {
            this.form = form;
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

        private void controllerPoll(object sender, DoWorkEventArgs e)
        {
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Variables.controllerStatus = "No joystick/Gamepad found.";
                Console.ReadKey();
                Environment.Exit(1);
            }

            // Instantiate the joystick
            var joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);
            Variables.controllerStatus = "Found Joystick / Gamepad!";

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            // Poll events from joystick
            while (true)
            {

                joystick.Poll();
                var datas = joystick.GetCurrentState();
                Application.DoEvents();
                Thread.Sleep(1);

                //controllerData[0] = mapInt(Int32.Parse(datas.PointOfViewControllers.GetValue(0).ToString()), 0, 65534, 0, 255); 
                //controllerData[1] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, 0, 255, 1); // min is bottom max is top L-STICK UP-DOWN "0-255"
                controllerData[2] = mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -150, 150); //L-STICK LEFT-RIGHT "-500-500" //roll %30 of 1000 us, total 300 uS
                controllerData[3] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, -350, 350, 1); //L-STICK UP-DOWN //throttle %70 of 1000 uS, total 700 uS

                if (Variables.controllerType == 1)
                {
                    //FOR DUALSHOCK 3
                    controllerData[4] = mapInt(Int32.Parse(datas.RotationX.ToString()), 0, 65534, -400, 400);//R-STICK LEFT-RIGHT "-1000 -1000"  %40 of 1000 us, OTHER %20 IS FOR YAW AXIS
                    controllerData[5] = mapInt(Int32.Parse(datas.RotationY.ToString()), 0, 65534, -400, 400, 1);//R-STICK UP-DOWN "--1000-1000"  %40 of 1000 us
                }
                if (Variables.controllerType == 0)
                {
                    //FOR DUALSHOCK 2
                    controllerData[4] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -400, 400);
                    controllerData[5] = mapInt(Int32.Parse(datas.RotationZ.ToString()), 0, 65534, -400, 400, 1);
                }
                controllerData[6] = Convert.ToInt32(datas.Buttons.GetValue(2)); //SQUARE
                controllerData[7] = Convert.ToInt32(datas.Buttons.GetValue(1)); //O
                controllerData[8] = Convert.ToInt32(datas.Buttons.GetValue(0)); //X
                controllerData[9] = Convert.ToInt32(datas.Buttons.GetValue(3)); //Triangle
                controllerData[10] = Convert.ToInt32(datas.Buttons.GetValue(7)); //START
                controllerData[11] = Convert.ToInt32(datas.Buttons.GetValue(5)); //R1
                controllerData[12] = Convert.ToInt32(datas.Buttons.GetValue(6)); //SELECT
                controllerData[13] = Convert.ToInt32(datas.Buttons.GetValue(4)); //L1
                controllerData[14] = Convert.ToInt32(datas.Buttons.GetValue(9)); //R3
                controllerData[15] = Convert.ToInt32(datas.Buttons.GetValue(8)); //L3
                controllerData[16] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -200, 200); //R2 L2 --Yaw value %20 of 1000 us
                form.controllerData = controllerData;

                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

        }
        #endregion privateFunctions

        #region publicFunctions
        public void StartPoll()
        {
            if (!getController.IsBusy)
            {
                getController.WorkerReportsProgress = false;
                getController.WorkerSupportsCancellation = true;
                getController.DoWork += controllerPoll;
                getController.RunWorkerAsync();
            }
            Thread.Sleep(500); // Connection Time!
            form.joyStickStatusLabel.Text = Variables.controllerStatus;
        }

        public void StopPoll()
        {
            if (getController.IsBusy) getController.CancelAsync();
        }
        #endregion publicFunctions
    }
}
