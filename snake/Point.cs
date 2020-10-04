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
            if (direction == Direction.Right)
                X += offset;
            else if (direction == Direction.Left)
                X -= offset;

            if (direction == Direction.Top)
                Y -= offset;
            else if (direction == Direction.Bottom)
                Y += offset;
        }

        public bool IsHit(Point p)
        {
            return p.X == X && p.Y == Y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Z);
        }

        public void Clear()
        {
            Z = ' ';
            Draw();
        }
    }
}
