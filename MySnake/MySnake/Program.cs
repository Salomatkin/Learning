using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 4, '+');
            Point p2 = new Point(7, 2, '*');
            Point p3 = new Point(2, 9, '#');
            Point p4 = new Point(4, 8, '@');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach(Point i in pList)
            {
                i.Draw();
            }
            Console.Read();
        }


    }
}
