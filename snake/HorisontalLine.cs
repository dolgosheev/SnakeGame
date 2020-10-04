using System;
using System.Collections.Generic;

namespace snake
{
    internal class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight, int y, char z)
        {
            Line = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, z);
                Line.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
