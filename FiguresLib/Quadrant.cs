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
        public Quadrant(Point[] points, Color color, int lifeTime, bool isPulsing)
            : base(points, FigureType.Qudrant, lifeTime, color, isPulsing)
        {
        }

        public double Side()
        {
            double diagonal = points[0].Lenght(points[1]);
            return diagonal / Math.Sqrt(2);
        }

        public override bool IsContainPoint(Point point)
        {
            double centerX = (points[0].x + points[1].x) / 2.0;
            double centerY = (points[0].y + points[1].y) / 2.0;

            double halfSide = Side() / 2.0;

            double scaledHalf = halfSide * Scale;

            return Math.Abs(point.x - centerX) <= scaledHalf &&
                   Math.Abs(point.y - centerY) <= scaledHalf;
        }

        public override double Perimetr() => 4 * Side();
        public override double Square() => Side() * Side();

        public override string ToString() => $"Квадрат: {base.ToString()}";
    }
}
