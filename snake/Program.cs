using System;
using System.Threading;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Console.SetWindowSize(82, 32);
            Console.SetBufferSize(82, 32);

            #region wrap

            HorisontalLine upLine = new HorisontalLine(0, 80, 0, '-');
            upLine.Draw();
            HorisontalLine downLine = new HorisontalLine(0, 80, 30, '-');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 1, 30, '|');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(80, 1, 30, '|');
            rightLine.Draw();

            #endregion

            Point p1 = new Point(2, 2, '*');

            Snake snake = new Snake(p1, 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
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
