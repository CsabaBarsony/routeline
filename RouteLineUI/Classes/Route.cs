using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteLineUI.Classes
{
    public class Route
    {
        public Query query { get; set; }
        public List<Location> locations { get; set; }
    }
}
