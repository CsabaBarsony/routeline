using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteLineUI.Classes
{
    public class Marker
    {
        public static Point getEdge(double angle, Bitmap bitmap)
        {
            int x = (int)Math.Ceiling(Math.Sin(angle) * bitmap.Width / 2.0 + bitmap.Width / 2.0);
            int y = (int)Math.Ceiling(Math.Cos(angle) * -1.0 * bitmap.Height / 2.0 + bitmap.Height / 2.0);
            return new Point(x, y);
        }
    }
}
