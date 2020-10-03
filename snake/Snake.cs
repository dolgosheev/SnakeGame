using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            _line = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                _line.Add(p);
            }
        }
    }
}
