using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Figure
    {
        protected List<Point> _line;

        public void Draw()
        {
            foreach (Point point in _line)
            {
                point.Draw();
            }
        }
    }
}
