using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLib
{
    public interface IDraw
    {
        void Draw(Figure figure);

        void Erase(Figure figure);
    }
}
