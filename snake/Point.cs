using System;

namespace snake
{

    internal class Point
    {
        public int X;
        public int Y;
        public char Z;

        public Point(int x, int y, char z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Z);
        }
    }
}
