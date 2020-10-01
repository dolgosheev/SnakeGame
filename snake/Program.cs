using System;

namespace snake
{
    internal class Program
    {
        private static void Main()
        {
            Point p1 = new Point(1, 2, '#');
            Point p2 = new Point(2, 3, '$');

            p1.Draw();
            p2.Draw();

            Console.Read();
        }


    }
}
