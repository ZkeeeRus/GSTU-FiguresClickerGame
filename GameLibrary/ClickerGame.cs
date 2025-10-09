using DrawLib;
using FiguresLib;
using System;
using System.Collections.Generic;
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

            foreach(Figure f in missedFigures)
                score -= f.GetScore() / 3;



            return score < 0 ? 0 : score;
        }

        public void AddNewFigure()
        {
            Figure figure = FigureFabric.GetNewFigure(maxX, maxY, minX, minY);

            activeFigures.Add(figure);

            draw.Draw(figure);
        }

        public void LifeCycle()
        {
            Queue<Figure> removeFigures = new Queue<Figure>();

            foreach (Figure f in activeFigures)
            {
                f.DecriseLifetime();
                if (!f.IsAlive())
                    removeFigures.Enqueue(f);
            }

            while (removeFigures.Count > 0)
            {
                var figure = removeFigures.Dequeue();

                missedFigures.Add(figure);
                activeFigures.Remove(figure);

                EraseFigure(figure);
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

                EraseFigure(figure);
            }
        }


        public void DrawAllFigures()
        {
            foreach (Figure figure in activeFigures)
            {
                draw.Draw(figure);
            }
        }

        public void EraseAllFigures()
        {
            foreach (Figure figure in activeFigures)
            {
                draw.Erase(figure);
            }
        }

        public void EraseFigure(Figure figure)
        {
            draw.Erase(figure);
        }
    }
}
