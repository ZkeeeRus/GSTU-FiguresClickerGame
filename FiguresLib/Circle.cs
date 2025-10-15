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
        public Circle(Point[] points, Color color, int lifeTime, bool isPulsing)
            : base(points, FigureType.Cicle, lifeTime, color, isPulsing)
        {
        }

        public double Radius()
        {
            return points[0].Lenght(points[1]);
        }

        public override bool IsContainPoint(Point point)
        {
            double distance = points[0].Lenght(point);
            double scaledRadius = Radius() * Scale;
            return distance <= scaledRadius;
        }

        public override double Perimetr() => 2 * Math.PI * Radius();
        public override double Square() => Math.PI * Radius() * Radius();

        public override string ToString() => $"Окружность: {base.ToString()}";
    }
}