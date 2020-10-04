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

        internal bool IsHitTail()
        {
            var head = _line.Last();
            for (int i = 0; i < _line.Count - 2; i++)
            {
                if (head.IsHit(_line[i]))
                    return true;
            }

            return false;
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
                _line.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
