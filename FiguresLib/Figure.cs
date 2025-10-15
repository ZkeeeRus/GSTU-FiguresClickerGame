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
        public FigureType type { get; }

        public Color color;
        public int lifeTime;

        public bool IsPulsing { get; protected set; }
        public double Scale { get; protected set; } = 1.0;

        private double scaleDirection = 1.0f; // + grow / - shrink
        private const double MinScale = 0.8f;
        private const double MaxScale = 1.5f;
        private const double ScaleSpeed = 0.03f;

        public Figure(Point[] points, FigureType type, int lifeTime, Color color, bool isPulsing = false)
        {
            this.points = points;
            this.type = type;
            this.lifeTime = lifeTime;
            this.color = color;
            this.IsPulsing = isPulsing;
            this.Scale = 1.0f;
        }

        public virtual void Update()
        {
            if (!IsPulsing)
                return;

            Scale += scaleDirection * ScaleSpeed;

            if (Scale >= MaxScale)
            {
                Scale = MaxScale;
                scaleDirection = -1.0f;
            }
            else if (Scale <= MinScale)
            {
                Scale = MinScale;
                scaleDirection = 1.0f;
            }
        }

        public abstract double Square();
        public virtual double ScaledSquare() => Square() * Scale * Scale;

        public abstract double Perimetr();

        public abstract bool IsContainPoint(Point point);

        public void DecriseLifetime()
        {
           if(lifeTime > 0)
                lifeTime--;
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
