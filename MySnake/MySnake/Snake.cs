using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Snake : Figure
    {
        Dir dir;

        public Snake(Point tail, int length, Dir _dir)
        {
            dir = _dir;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point( tail );
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Creep()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            tail.Clear();

            Point head = GetNewHead();
            pList.Add(head);
            head.Draw();
        }

        public Point GetNewHead()
        {
            Point Head = pList.Last();
            Point NewHead = new Point(Head);
            NewHead.Move(1, dir);
            return NewHead;  
        }
        public void GetKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                dir = Dir.LEFT;
            else if (key == ConsoleKey.RightArrow)
                dir = Dir.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                dir = Dir.UP;
            else if (key == ConsoleKey.DownArrow)
                dir = Dir.DOWN;
        }

    }
}
