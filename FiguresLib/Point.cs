using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Lenght(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x - x, 2) +
                             Math.Pow(point.y - y, 2));
        }
    }
}
