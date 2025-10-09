using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            int n = 10;

            for (int i = 0; i < n; i++)
            {
                Figure figure = FigureFabric.GetNewFigure(1000, 1000);
                figures.Add(figure);

            }

            foreach (var figure1 in figures)
            {

                Console.WriteLine(figure1.ToString());
            }

        }
    }
}
