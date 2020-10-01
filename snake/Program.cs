using System;

namespace snake
{
    internal class Program
    {
        private static void Main()
        {
            Draw(1,2,'#');

            Console.Read();
        }

        static void Draw(int x, int y, char z)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(z);
        }
    }
}
