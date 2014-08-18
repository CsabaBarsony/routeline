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

            NpgsqlCommand command = new NpgsqlCommand("select * from status_updates where id > 1 and id < 4", conn);

            String message = "";

            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        message += reader[i] + ";";
                    }
                    message += "\n";
                }
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show(message);
        }
    }
}
