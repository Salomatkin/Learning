using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int xn, int yn, char symn)
        {
            x = xn;
            y = yn;
            sym = symn;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }


    }
}
