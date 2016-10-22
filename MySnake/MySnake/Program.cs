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
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 4;
            p1.sym = '@';
            p1.Draw();


            Console.Read();
        }
    }
}
