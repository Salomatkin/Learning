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
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Dir dir)
        {
            if(dir==Dir.RIGHT)
            {
                x = x + offset;
            }
            else if (dir==Dir.LEFT)
            {
                x = x - offset;
            }
            else if(dir==Dir.UP)
            {
                y = y - offset;
            }
            else if (dir==Dir.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            sym=' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }
    }
}
