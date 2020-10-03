using System.Collections.Generic;

namespace snake
{
    internal class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight, int y, char z)
        {
            _line = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, z);
                _line.Add(p);
            }
        }

    }
}
