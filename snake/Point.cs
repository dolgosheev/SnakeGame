using System;

namespace snake
{
    internal class Point
    {
        public int X;
        public int Y;
        public char Z;

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Z);
        }

    }
}
