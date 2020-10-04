using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Figure
    {
        protected List<Point> _line;

        public virtual void Draw()
        {
            foreach (Point point in _line)
            {
                point.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var point in _line)
            {
                if (figure.IsHit(point))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in _line)
            {
                if (p.IsHit(point))
                    return true;
            }

            return false;
        }

    }
}
