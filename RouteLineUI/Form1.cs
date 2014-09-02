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
        private NpgsqlConnection conn;
        private List<Location> locations;

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
            //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(46.25, 20.14), GMarkerGoogleType.green);
            //markerOverlay.Markers.Add(marker);
            /*myMap.Overlays.Add(routesOverlay);*/

            String connString = "Server=csabavm;Port=5432;User Id=postgres;Password=Asd..123;Database=tmcdb_production;";
            conn = new NpgsqlConnection(connString);
            conn.Open();

            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(46, 20));
            //points.Add(new PointLatLng(46, 21));
            //points.Add(new PointLatLng(47, 21));
            //GMapRoute path = new GMapRoute(points, "bla");
            //markerOverlay.Routes.Add(path);

            //gheat.PointManager pm = new gheat.PointManager();

            //var p = new PointLatLng(10.0, 10.0);
            //pm.AddPoint(p);
            //pm.AddPoint(new PointLatLng(46, 21));
            //pm.AddPoint(new PointLatLng(47, 21));

            //Bitmap image;
            //System.IO.MemoryStream stream;
            //image = gheat.GHeat.GetTile(pm, "majom", 12, 46, 20);
            //image.Save("test.png");
            
        }

        private void buttonSqlOk_Click(object sender, EventArgs e)
        {
            if (textBoxSql.Text == "") return;

            NpgsqlCommand command = new NpgsqlCommand(textBoxSql.Text, conn);
            command.CommandTimeout = 100000000;
            locations = new List<Location>();

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
                //conn.Close();
            }

            if (radioButtonMarker.Checked)
            {
                Bitmap img = new Bitmap("blue_dot.png");
                foreach (Location l in locations)
                {
                    markerOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(l.lat, l.lon), img));
                }
            }
            else if (radioButtonLine.Checked)
            {
                List<PointLatLng> points = new List<PointLatLng>();

                foreach (Location l in locations)
                {
                    points.Add(new PointLatLng(l.lat, l.lon));
                }

                GMapRoute path1 = new GMapRoute(points, "myroute");
                path1.Stroke = new Pen(Color.FromArgb(0, 255, 0), 5.0f);
                GMapRoute path2 = new GMapRoute(points, "myroute");
                path2.Stroke = new Pen(Color.FromArgb(255, 0, 0), 2.0f);
                markerOverlay.Routes.Add(path1);
                markerOverlay.Routes.Add(path2);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            locations = null;
            markerOverlay.Markers.Clear();
            markerOverlay.Routes.Clear();
        }

        private void buttonManageSql_Click(object sender, EventArgs e)
        {
            FormManageSql formManageSql = new FormManageSql();
            formManageSql.ShowDialog();
        }
    }
}
