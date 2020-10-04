using System;
using System.Threading;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
            Console.SetBufferSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);

            int wResolution = Console.BufferWidth - 2;
            int hResolution = Console.BufferHeight - 2;

            Walls walls = new Walls(wResolution, hResolution);
            walls.Draw();

            Point p = new Point(2, 2, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(wResolution, hResolution, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }

            // ReSharper disable once FunctionNeverReturns
        }

    }
}
