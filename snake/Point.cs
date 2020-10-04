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

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Z = p.Z;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                X += offset;
            else if(direction == Direction.RIGHT)
                X -= offset;

            if (direction == Direction.TOP)
                Y += offset;
            else if (direction == Direction.BOTTOM)
                Y += offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Z);
        }

        public void Clear()
        {
            Z = ' ';
            Draw();
        }
    }
}
