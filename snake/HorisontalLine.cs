using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HorisontalLine
    {
        private List<Point> hline;

        public HorisontalLine(int xLeft,int xRight,int y,char z)
        {
            hline = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,z);
                hline.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var point in hline)
            {
                point.Draw();
            }
        }

    }
}
