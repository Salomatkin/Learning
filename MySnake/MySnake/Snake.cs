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
    }
}
