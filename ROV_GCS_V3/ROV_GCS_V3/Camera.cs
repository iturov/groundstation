using AForge.Video;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROV_GCS_V3
{
    class Camera
    {
        #region variables
        public event NewFrameEventHandler EventHandler;
        public event VideoSourceErrorEventHandler errorHandler;
        private MJPEGStream stream = null;
        #endregion variables

        #region publicFunctions
        public Camera()
        {

        }

        public void initialize(string ip = "192.168.137.69", int port = 8091)
        {
            stream = new MJPEGStream("http://" + ip + ":" + port.ToString() + "/?action=stream");
            stream.NewFrame += new NewFrameEventHandler(EventHandler);
            stream.Source = "http://" + ip + ":" + port.ToString() + "/?action=stream";
            //stream.VideoSourceError += new VideoSourceErrorEventHandler(errorHandler);
        }

        public void update(bool state, string ip = "192.168.137.69", int port = 8091)
        {

            if (state) //Start Stream
            {
                stream.Source = "http://" + ip + ":" + port.ToString() + "/?action=stream";
                if (!stream.IsRunning)
                {

                    stream.Start();
                }

            }
            else
            {
                try
                {
                    if (stream.IsRunning)
                    {
                        if(stream.FramesReceived > 0)
                        {
                            //stream.Stop();
                        }
                        stream.Stop();

                    }
                    else
                    {

                        return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("", e);
                }
            }
        }
        #endregion publicFunctions
    }
}
