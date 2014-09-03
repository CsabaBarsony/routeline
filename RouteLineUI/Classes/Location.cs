using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

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

        public static Location create(Npgsql.NpgsqlDataReader reader)
        {
            Location l = new Location();
            l.id = int.Parse(reader[0].ToString());
            l.tenantId = int.Parse(reader[1].ToString());
            l.userId = int.Parse(reader[2].ToString());
            l.trackingDeviceId = int.Parse(reader[3].ToString());
            l.trackingSessionId = int.Parse(reader[4].ToString());
            l.status = int.Parse(reader[5].ToString());
            l.lat = double.Parse(reader[6].ToString());
            l.lon = double.Parse(reader[7].ToString());
            l.alt = double.Parse(reader[8].ToString());
            l.bearing = double.Parse(reader[9].ToString());
            l.speed = double.Parse(reader[10].ToString());
            l.accuracy = double.Parse(reader[11].ToString());
            l.ts = reader[12].ToString();

            return l;
        }
    }
}
