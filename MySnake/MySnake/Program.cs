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

            RabbitMaker RabbitMaker = new RabbitMaker(80, 25, 'Ж');
            Point rabbit = RabbitMaker.MakeRabbit();
            rabbit.Draw();

            while(true)
            {
                if (snake.Eat(rabbit))
                {
                    rabbit = RabbitMaker.MakeRabbit();
                    rabbit.Draw();
                }
                else
                {
                    snake.Creep();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.GetKey(key.Key);
                }
                System.Threading.Thread.Sleep(250);
                //snake.Creep();
            }
//            snake.Creep();
//            Thread.Sleep(300);
   
            //Console.Read();
        }


    }
}
