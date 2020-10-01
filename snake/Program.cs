using System;

namespace snake
{
    internal class Program
    {
        private static void Main()
        {
            Point p1 = new Point
            {
                X = 1,
                Y = 2,
                Z = '#'
            };

            Point p2 = new Point
            {
                X = 3,
                Y = 4,
                Z = '$'
            };

            p1.Draw();
            p2.Draw();

            Console.Read();
        }


    }
}
