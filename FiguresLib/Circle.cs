using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Circle : Figure
    {
        public Circle(Point[] points, Color color, int lifeTime) : base(points, FigureType.Cicle, lifeTime, color)
        {

        }

        public double Radius()
        {
            return points[0].Lenght(points[1]);
        }

        public override bool IsContainPoint(Point point)
        {
            return (Math.Pow(point.x - points[0].x, 2) + Math.Pow(point.y - points[0].y, 2)) <= Math.Pow(Radius(), 2);
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * Radius();
        }

        public override double Square()
        {
            return Math.PI * Radius() * Radius();
        }

        public override string ToString()
        {
            return $"Окружность: " + base.ToString();
        }
    }
}
