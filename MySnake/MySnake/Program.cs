using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Snake snake = new Snake(new Point(10, 10, '*'), 4, Dir.RIGHT);
            snake.drw();
            snake.Creep();

            //Console.Read();
        }


    }
}
