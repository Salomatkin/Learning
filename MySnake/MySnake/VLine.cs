using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class VLine :Figure
    {
        public VLine(int x, int y1, int y2, char sym)
        {
            pList = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
    }
}
