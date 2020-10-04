using System;
using System.Threading;

namespace snake
{
    internal class Program
    {
        public static int x { get; set; }
        public static int y { get; set; }

        private static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
            Console.SetBufferSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);

            int wResolution = x = Console.BufferWidth - 2;
            int hResolution = y = Console.BufferHeight - 2;

            Walls walls = new Walls(wResolution, hResolution);
            walls.Draw();

            Point p = new Point(2, 2, '*');
            Snake snake = new Snake(p, 3, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(wResolution, hResolution, '$');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Red;
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
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

            WriteGameOver();
            Console.ReadLine();

            // ReSharper disable once FunctionNeverReturns
        }

        private static void WriteGameOver()
        {
            int xOffset = (x / 2) - 14;
            int yOffset = (y / 2) -2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            WriteText("Автор:  Alexander Dolgosheev", xOffset , yOffset++);
            WriteText("============================", xOffset, yOffset);
        }

        private static void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
