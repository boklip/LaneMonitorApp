using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneMonitorApp2.Models
{
    public class Lane
    {
        public int LaneID { get; set; }
        public string LaneName { get; set; }
        public string Status { get; set; }

        public List<Camera> Cameras { get; set; } = new List<Camera>();
    }
}
