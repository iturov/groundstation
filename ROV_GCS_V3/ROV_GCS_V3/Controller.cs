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
        private static int[] roboticArm = new int[5];
        public static int[] robotValues = new int[5];
        public int Kp = 10;
        private float scaleFactor = 2.3f;
        System.Timers.Timer timer = new System.Timers.Timer();
        BackgroundWorker getController = new BackgroundWorker();
        Form1 form;
        #endregion variables

        #region privateFunctions
        public Controller(Form1 form)
        {
            timer.Elapsed += timer_Tick;
            timer.Interval = 10;
            timer.Enabled = true;
            this.form = form;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            roboticArm[0] += (controllerData[8] - controllerData[6]) * (int)timer.Interval / 10 * Kp;
            roboticArm[1] += (controllerData[10] - controllerData[12]) * (int)timer.Interval / 10 * Kp;
            roboticArm[2] += (controllerData[11] - controllerData[13]) * (int)timer.Interval / 10 * Kp;
            roboticArm[3] += (controllerData[9] - controllerData[7]) * (int)timer.Interval / 10 * Kp;
            roboticArm[4] += (controllerData[14] - controllerData[15]);
            for(int i = 0; i < roboticArm.Length; i++)
            {
                roboticArm[i] = constrain(roboticArm[i], 0, 1000);
            }
            robotValues[0] = 1800 + mapInt(roboticArm[0], 0, 1000, 0, 500); //GRIPPER
            robotValues[1] = 500 + mapInt(roboticArm[1], 0, 1000, 0, 1273); //ELBOW1 ROLL reverseeee!!!!
            robotValues[2] = 500 + mapInt(roboticArm[2], 0, 1000, 0, 1900); //ELBOW2 PITCH
            robotValues[3] = 1200 + mapInt(roboticArm[3], 0, 1000, 0, 800); //cam
            robotValues[4] = constrain(roboticArm[4], 0, 1);
        }

        private static int constrain(int value, int min, int max)
        {
            if (value > max) value = max;
            if (value < min) value = min;
            return value;
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

            if (Variables.controllerType == 1)
            {
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;
            }

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Variables.controllerStatus = false;
            }

            // Instantiate the joystick
            var joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);
            Variables.controllerStatus = true;

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


                if (Variables.controllerType == 1)
                {
                    //FOR DUALSHOCK 3
                    controllerData[2] = mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -150, 150); //L-STICK LEFT-RIGHT "-500-500" //roll %30 of 1000 us, total 300 uS
                    controllerData[3] = mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, -350, 350, 1); //L-STICK UP-DOWN //throttle %70 of 1000 uS, total 700 uS
                    controllerData[16] = mapInt(Int32.Parse(datas.RotationX.ToString()), 0, 65534, -200, 200, 1);//R-STICK LEFT-RIGHT "-1000 -1000"  %40 of 1000 us, OTHER %20 IS FOR YAW AXIS
                    controllerData[5] = mapInt(Int32.Parse(datas.RotationY.ToString()), 0, 65534, -400, 400, 1);//R-STICK UP-DOWN "--1000-1000"  %40 of 1000 us
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
                    controllerData[4] = mapInt(Int32.Parse(datas.Z.ToString()), 0, 65534, -400, 400); //R2 L2 --Yaw value %20 of 1000 us
                }

                if (Variables.controllerType == 0)
                {
                    //FOR JOYSTICK
                    controllerData[2] = (int)((float)mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -150, 150) / scaleFactor); //L-STICK LEFT-RIGHT "-500-500" //roll %30 of 1000 us, total 300 uS
                    controllerData[3] = (int)((float)mapInt(Int32.Parse(datas.Sliders[0].ToString()), 0, 65534, -350, 350, 1) / scaleFactor); //L-STICK UP-DOWN //throttle %70 of 1000 uS, total 700 uS
                    controllerData[16] =(int)((float)mapInt(Int32.Parse(datas.RotationZ.ToString()), 0, 65534, -200, 200, 1) / scaleFactor);//R-STICK LEFT-RIGHT "-1000 -1000"  %40 of 1000 us, OTHER %20 IS FOR YAW AXIS
                    controllerData[5] = (int)((float)mapInt(Int32.Parse(datas.Y.ToString()), 0, 65534, -400, 400, 1) / scaleFactor);//R-STICK UP-DOWN "--1000-1000"  %40 of 1000 us
                    int pov = Convert.ToInt32(datas.PointOfViewControllers[0].ToString());
                    controllerData[6] = Convert.ToInt32(datas.Buttons.GetValue(1)); //SQUARE
                    controllerData[7] = Convert.ToInt32(datas.Buttons.GetValue(4)); //O
                    controllerData[8] = Convert.ToInt32(datas.Buttons.GetValue(0)); //X
                    controllerData[9] = Convert.ToInt32(datas.Buttons.GetValue(5)); //Triangle
                    controllerData[14] = Convert.ToInt32(datas.Buttons.GetValue(3)); //R3
                    controllerData[15] = Convert.ToInt32(datas.Buttons.GetValue(2)); //L3
                    controllerData[4] = (int)((float)mapInt(Int32.Parse(datas.X.ToString()), 0, 65534, -400, 400, 1) / scaleFactor); //R2 L2 --Yaw value %20 of 1000 us
                    if (pov == 0)
                    {
                        controllerData[10] = 1;
                        controllerData[12] = 0;
                        controllerData[11] = 0;
                        controllerData[13] = 0;

                    }
                    else if (pov == 9000)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 0;
                        controllerData[11] = 1;
                        controllerData[13] = 0;
                    }
                    else if (pov == 18000)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 1;
                        controllerData[11] = 0;
                        controllerData[13] = 0;
                    }
                    else if (pov == 27000)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 0;
                        controllerData[11] = 0;
                        controllerData[13] = 1;
                    }
                    else if (pov == -1)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 0;
                        controllerData[11] = 0;
                        controllerData[13] = 0;
                    }
                    else if (pov == 4500)
                    {
                        controllerData[10] = 1;
                        controllerData[12] = 0;
                        controllerData[11] = 1;
                        controllerData[13] = 0;
                    }
                    else if (pov == 13500)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 1;
                        controllerData[11] = 1;
                        controllerData[13] = 0;
                    }
                    else if (pov == 22500)
                    {
                        controllerData[10] = 0;
                        controllerData[12] = 1;
                        controllerData[11] = 0;
                        controllerData[13] = 1;
                    }
                    else if (pov == 31500)
                    {
                        controllerData[10] = 1;
                        controllerData[12] = 0;
                        controllerData[11] = 0;
                        controllerData[13] = 1;
                    }
                    /*
                    var datass = joystick.GetBufferedData();
                    foreach (var dt in datass)
                        Console.WriteLine(dt);
                    */
                }
                
                form.controllerData = controllerData;

                for(int d = 0; d < 6; d++)
                {
                    controllerData[d] = threshold(controllerData[d], 50);
                }

                System.Threading.Thread.Sleep(1);
                Application.DoEvents();

                //PASS VALUES TO THE VEHICLE CLASS
                Vehicle.dataSent[0] = controllerData[3].ToString();
            }

        }
        
        private int threshold(int value, int th = 15)
        {
            if (Math.Abs(value) < th) value = 0;
            return value;
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
            Thread.Sleep(250); // Connection Time!
            if (Variables.controllerStatus) form.joyStickStatusLabel.Text = "Connected!";
        }

        public void StopPoll()
        {
            if (getController.IsBusy) getController.CancelAsync();
        }
        #endregion publicFunctions
    }
}
