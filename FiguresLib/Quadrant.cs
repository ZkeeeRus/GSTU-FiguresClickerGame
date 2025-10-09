using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Quadrant : Figure
    {
        public Quadrant(Point[] points, Color color, int lifeTime) : base(points, FigureType.Qudrant, lifeTime, color)
        {

        }

        public double Side()
        {
            double diag = points[0].Lenght(points[1]);
            return diag / Math.Sqrt(2);
        }

        public override bool IsContainPoint(Point point)
        {
            bool isContain = false;

            if ((point.x >= points[0].x) && (point.x <= points[1].x) && (point.y <= points[1].y) && (point.y >= points[0].y))
            {
                isContain = true;
            }

            return isContain;
        }

        public override double Perimetr()
        {
            return 4 * Side();
        }

        public override double Square()
        {
            return Side() * Side();
        }

        public override string ToString()
        {
            return $"Квадрат: " + base.ToString();
        }
    }
}
