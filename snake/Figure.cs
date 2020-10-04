using System.Collections.Generic;

namespace snake
{
    internal class Figure
    {
        protected List<Point> Line;

        public virtual void Draw()
        {
            foreach (Point point in Line)
            {
                point.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Point point in Line)
            {
                if (figure.IsHit(point))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (Point p in Line)
            {
                if (p.IsHit(point))
                    return true;
            }

            return false;
        }

    }
}
