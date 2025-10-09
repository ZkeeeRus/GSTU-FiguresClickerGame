using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class Figure
    {
        public Point[] points;
        public FigureType Type { get; }

        public Color color;
        public int lifeTime;

        public Figure(Point[] points, FigureType type, int lifeTime, Color color)
        {
            this.points = points;
            this.Type = type;
            this.lifeTime = lifeTime;
            this.color = color;
        }

        public abstract double Square();

        public abstract double Perimetr();

        public abstract bool IsContainPoint(Point point);

        public void DecriseLifetime()
        {
           if(lifeTime > 0) lifeTime--;
        }

        public bool IsAlive()
        {
            return lifeTime > 0;
        }

        public int GetScore()
        {
            return (int)(Math.Round(10000 / Square()));
        }


        public override string ToString()
        {
            return $"P = {Perimetr()}, S = {Square()}";
        }
    }
}
