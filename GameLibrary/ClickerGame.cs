using DrawLib;
using FiguresLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class ClickerGame
    {
        private IDraw draw = null;

        private string playerName;

        private int minX = 0;
        private int minY = 0;
        private int maxX;
        private int maxY;


        private List<Figure> activeFigures = new List<Figure>();
        private List<Figure> clickedFigures = new List<Figure>();

        private List<Figure> missedFigures = new List<Figure>();

        public ClickerGame(IDraw draw, string playerName, int maxX, int maxY, int minX = 0, int minY = 0)
        {
            this.draw = draw;
            this.playerName = playerName;

            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
        }


        public int GetScore()
        {
            int score = 0;

            foreach (Figure f in clickedFigures)
                score += f.GetScore();

            foreach (Figure f in missedFigures)
                score -= f.GetScore() / 3;


            return score < 0 ? 0 : score;
        }

        public void AddNewFigure()
        {
            Figure figure = FigureFabric.GetNewFigure(maxX, maxY, minX, minY);

            activeFigures.Add(figure);
        }

        public void LifeCycle()
        {
            var toRemove = new List<Figure>();

            foreach (var f in activeFigures)
            {
                f.DecriseLifetime();
                if (!f.IsAlive())
                {
                    toRemove.Add(f);
                }
            }

            foreach (var f in toRemove)
            {
                activeFigures.Remove(f);
                missedFigures.Add(f);
            }
        }

        public void OnPlayerClick(int x, int y)
        {
            OnPlayerClick(new Point(x, y));
        }

        public void OnPlayerClick(Point point)
        {
            Queue<Figure> clicked = new Queue<Figure>();

            foreach (Figure f in activeFigures)
            {
                if (f.IsContainPoint(point))
                {
                    clicked.Enqueue(f);
                }
            }

            while (clicked.Count > 0)
            {
                var figure = clicked.Dequeue();

                clickedFigures.Add(figure);
                activeFigures.Remove(figure);
            }
        }

        public void Render()
        {
            draw.Clear();
            foreach (var figure in activeFigures)
            {
                figure.Update();
                draw.Draw(figure);
            }
        }
        public void ClearAll()
        {
            draw.Clear();
            Debug.Write("test");
        }
    }
}
