using System;

namespace snake
{
    internal class Program
    {
        private static void Main()
        {
            Point p1 = new Point(1, 1, '*');
            Point p2 = new Point(2, 2, '#');

            p1.Draw();
            p2.Draw();

            Move(p1,5,5);
            p1.Draw();

            Console.Read();
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.X += dx;
            p.Y += dy;
        }

        public static void Reset(Point p)
        {
             p = new Point();
        }

    }
}
