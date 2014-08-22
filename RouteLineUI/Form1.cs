using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using RouteLineUI.Classes;

namespace RouteLineUI
{
    public partial class Form1 : Form
    {
        private GMapOverlay markerOverlay = new GMapOverlay("markers");
        private GMapOverlay routesOverlay = new GMapOverlay("routes");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            myMap.Position = new GMap.NET.PointLatLng(46.25, 20.15);
            myMap.Overlays.Add(markerOverlay);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(46.25, 20.14), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            /*myMap.Overlays.Add(routesOverlay);*/

            String connString = "Server=csabavm;Port=5432;User Id=postgres;Password=Asd..123;Database=tmcdb_production;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("select * from taxi_locations where id > 5000 and id < 10000", conn);
            List<Location> locations = new List<Location>();

            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
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

                    locations.Add(l);
                }
            }
            finally
            {
                conn.Close();
            }

            foreach (Location l in locations)
            {
                markerOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(l.lat, l.lon), GMarkerGoogleType.lightblue_dot));
            }
        }
    }
}
