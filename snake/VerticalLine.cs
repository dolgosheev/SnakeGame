using System.Collections.Generic;

namespace snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char z)
        {
            _line = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, z);
                _line.Add(p);
            }
        }

    }
}
