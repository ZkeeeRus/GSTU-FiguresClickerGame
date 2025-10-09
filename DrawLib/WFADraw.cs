using FiguresLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLib
{
    public class WFADraw : IDraw
    {
        public Graphics graphics;
        private Color backgroundColor;


        public WFADraw(Color background, ref Graphics graphics)
        {
            backgroundColor = background;
            this.graphics = graphics;
        }

        public void Erase(Figure figure)
        {
            Draw(figure, backgroundColor);
        }

        public void Draw(Figure figure)
        {
            Draw(figure, figure.color);
        }

        public void Draw(Figure figure, Color color)
        {
            if (figure == null || graphics == null)
                return;


            Brush brush = new SolidBrush(color);
            int x, y, width, height;

            switch (figure.Type)
            {
                case FigureType.Cicle:
                    Circle circle = figure as Circle;

                    int r = (int)Math.Round(circle.Radius());

                    width = 2 * r;
                    height = width;

                    x = (int)circle.points[0].x - r;
                    y = (int)circle.points[0].y - r;

                    graphics.FillEllipse(brush, x, y, width, height);

                    break;

                case FigureType.Qudrant:
                    Quadrant quadrant = figure as Quadrant;

                    x = (int)quadrant.points[0].x;
                    y = (int)quadrant.points[0].y;

                    width = (int)quadrant.Side();
                    height = width;

                    graphics.FillRectangle(brush, x, y, width, height);

                    break;
            }
        }
    }
}
