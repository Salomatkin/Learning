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

            Walls walls = new Walls(80, 25);
            walls.drw();

            Snake snake = new Snake(new Point(10, 10, '*'), 4, Dir.RIGHT);
            snake.drw();

            RabbitMaker RabbitMaker = new RabbitMaker(80, 25, 'Ж');
            Point rabbit = RabbitMaker.MakeRabbit();
            while (true)
            {
                if (!snake.IsHit(rabbit))
                    break;
                else
                    rabbit = RabbitMaker.MakeRabbit();
            }
            rabbit.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                        break;
                if (snake.Eat(rabbit))
                {
                    while (true)
                    {
                        if (!snake.IsHit(rabbit))
                            break;
                        else
                            rabbit = RabbitMaker.MakeRabbit();
                    }
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
            Console.Write("GAME OVER");
            Console.Read();
        }


    }
}
