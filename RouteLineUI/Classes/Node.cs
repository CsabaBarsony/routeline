using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace RouteLineUI.Classes
{
    public class Node
    {
        private PointLatLng point;
        private int status;

        public Node(PointLatLng point, int status)
        {
            this.point = point;
            this.status = status;
        }
    }
}
