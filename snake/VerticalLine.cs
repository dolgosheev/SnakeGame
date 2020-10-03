using System.Collections.Generic;

namespace snake
{
    internal class VerticalLine
    {
        private readonly List<Point> vline;

        public VerticalLine(int x, int yTop, int yBottom, char z)
        {
            vline = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, z);
                vline.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point point in vline)
            {
                point.Draw();
            }
        }
    }
}
