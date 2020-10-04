using System;
using System.Collections.Generic;
using System.Linq;

namespace snake
{
    internal class Snake : Figure
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            _line = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                _line.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = _line.First();
            _line.Remove(tail);
            Point head = GetNextPoint();
            _line.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = _line.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.TOP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.BOTTOM;
                    break;
            }
        }
    }
}
