using System;
using System.Collections.Generic;
using System.Linq;

namespace snake
{
    internal class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            Line = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                Line.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = Line.First();
            Line.Remove(tail);
            Point head = GetNextPoint();
            Line.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = Line.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            Point head = Line.Last();
            for (int i = 0; i < Line.Count - 2; i++)
            {
                if (head.IsHit(Line[i]))
                    return true;
            }

            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    _direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    _direction = Direction.Top;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.Bottom;
                    break;
            }
            //if (key == ConsoleKey.LeftArrow)
            //    direction = Direction.LEFT;
            //else if (key == ConsoleKey.RightArrow)
            //    direction = Direction.RIGHT;
            //else if (key == ConsoleKey.UpArrow)
            //    direction = Direction.TOP;
            //else if (key == ConsoleKey.DownArrow)
            //    direction = Direction.BOTTOM;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Z = head.Z;
                Line.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
