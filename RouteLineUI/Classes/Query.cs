using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteLineUI.Classes
{
    public class Query
    {
        public String name { get; set; }
        public String description { get; set; }
        public String sql { get; set; }
        public String color { get; set; }

        public override string ToString()
        {
            if (this.name == null) return "";
            return this.name;
        }
    }
}
