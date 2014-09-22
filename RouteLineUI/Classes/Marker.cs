using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;

namespace RouteLineUI.Classes
{
    public class Marker : GMarkerGoogle
    {
        public int id;
        public Route route;

        public Marker(PointLatLng point, Bitmap bitmap, int id, Route route) : base(point, bitmap)
        {
            this.id = id;
            this.route = route;
        }
    }
}
