using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteLineUI.Classes
{
    public class Location
    {
        public int id { get; set; }
        public int tenantId { get; set; }
        public int userId { get; set; }
        public int trackingDeviceId { get; set; }
        public int trackingSessionId { get; set; }
        public int status { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double alt { get; set; }
        public double bearing { get; set; }
        public double speed { get; set; }
        public double accuracy { get; set; }
        public String ts { get; set; }
    }
}
