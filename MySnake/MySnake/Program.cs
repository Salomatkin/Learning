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
            Console.SetBufferSize(80, 25);

            HLine UpLine = new HLine(0, 78, 0, '+');
            HLine DownLine = new HLine(0, 78, 24, '+');
            VLine LeftLine = new VLine(0, 0, 24, '+');
            VLine RightLine = new VLine(78, 0, 24, '+');

            UpLine.drw();
            DownLine.drw();
            LeftLine.drw();
            RightLine.drw();

            List<Point> pList = new List<Point>();
            pList.Add(new Point(5, 4, '+'));
            pList.Add(new Point(7, 2, '*'));
            pList.Add(new Point(2, 9, '#'));
            pList.Add(new Point(4, 8, '@'));

            foreach(Point i in pList)
            {
                i.Draw();
            }

            HLine lineH = new HLine(2, 12, 3, '=');
            lineH.drw();

            VLine lineV = new VLine(3, 3, 15, '|');
            lineV.drw();

            Console.Read();
        }


    }
}
