using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class HLine : Figure
    {
        public HLine(int x1, int x2, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = x1; x <= x2; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
    }
}
