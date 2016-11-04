using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapW, int mapH)
        {
            wallList = new List<Figure>();

            wallList.Add(new HLine(0, mapW-2, 0, '+'));
            wallList.Add(new HLine(0, mapW-2, mapH-1, '+'));
            wallList.Add(new VLine(0, 0, mapH-1, '+'));
            wallList.Add(new VLine(mapW-2, 0, mapH-1, '+'));
        }

        public void drw()
        {
            foreach (var wall in wallList)
            {
                wall.drw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

    }
}
