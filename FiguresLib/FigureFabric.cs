using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class FigureFabric
    {
        public static Figure GetNewFigure(int maxX, int maxY, int minX = 0, int minY = 0)
        {
            Figure figure = null;

            Random rand = new Random();

            int typeFigure = rand.Next(0, 2);

            int x1 = rand.Next(minX, maxX);
            int y1 = rand.Next(minY, maxY);
            int side = rand.Next(1, Math.Min(maxX, maxY) / 8);

            Point[] points = { new Point(x1, y1), new Point(x1 + side, y1 + side)};

            int R = rand.Next(255);
            int G = rand.Next(255);
            int B = rand.Next(255);

            Color color = Color.FromArgb(R, G, B);

            int lifeTime = rand.Next(10, 51);
            bool isPulsing = rand.NextDouble() < 0.3;

            switch (typeFigure)
            {
                // Quadrant
                case 0:
                    figure = new Quadrant(points, color, lifeTime, isPulsing);
                    break;

                // Circle
                case 1:
                    figure = new Circle(points, color, lifeTime, isPulsing);
                    break;
            }


            return figure;
        }
    }
}
