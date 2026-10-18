using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneMonitorApp2.Models
{
    public class Camera
    {
        public int CameraID { get; set; }
        public int LaneID { get; set; }
        public string Position { get; set; }

        public string IPAddress { get; set; }

        public int Port { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string RtspUrl => $"rtsp://{Username}:{Password}@{IPAddress}:{Port}/Streaming/Chanels/102";
 }
}