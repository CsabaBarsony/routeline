using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /*myMap.Overlays.Add(markerOverlay);
            myMap.Overlays.Add(routesOverlay);*/
        }
    }
}
