using FiguresLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLib
{
    public class WFADraw : IDraw
    {
        public Graphics bufferGraphics;
        private Bitmap buffer;
        private Color backgroundColor;
        private Control renderTarget;


        public WFADraw(Control renderTarget)
        {
            this.renderTarget = renderTarget;
            this.backgroundColor = renderTarget.BackColor;
            ResizeBuffer();
        }

        public void ResizeBuffer()
        {
            if (buffer != null)
            {
                buffer.Dispose();
                bufferGraphics?.Dispose();
            }

            buffer = new Bitmap(renderTarget.Width, renderTarget.Height);
            bufferGraphics = Graphics.FromImage(buffer);

            Clear();
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
            if (figure == null || bufferGraphics == null) return;

            using (Brush brush = new SolidBrush(color))
            {
                switch (figure.type)
                {
                    case FigureType.Cicle:
                        Circle circle = figure as Circle;
                        double baseRadius = circle.Radius();
                        double scaledRadius = baseRadius * figure.Scale; // ← масштаб

                        int r = (int)Math.Round(scaledRadius);
                        int x = (int)circle.points[0].x - r;
                        int y = (int)circle.points[0].y - r;

                        bufferGraphics.FillEllipse(brush, x, y, 2 * r, 2 * r);
                        break;

                    case FigureType.Qudrant:
                        Quadrant quad = figure as Quadrant;
                        double baseSide = quad.Side();
                        double scaledSide = baseSide * figure.Scale; // ← масштаб

                        int x2 = (int)quad.points[0].x;
                        int y2 = (int)quad.points[0].y;
                        int w = (int)Math.Round(scaledSide);
                        int h = w;

                        bufferGraphics.FillRectangle(brush, x2, y2, w, h);
                        break;
                }
            }
        }

        public void Clear()
        {
            if (bufferGraphics != null)
            {
                bufferGraphics.Clear(backgroundColor);
            }
        }

        public void Present()
        {
            using (Graphics screenGraphics = renderTarget.CreateGraphics())
            {
                screenGraphics.DrawImage(buffer, 0, 0);
            }
        }
    }
}
