using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Point p1 = new Point(0, 0, '1');
            Point p2 = new Point(0, 2, '2');
            Point p3 = new Point(2, 0, '3');
            Point p4 = new Point(2, 2, '4');

            List<Point> listPoints = new List<Point>();
            
            listPoints.Add(p1);
            listPoints.Add(p2);
            listPoints.Add(p3);
            listPoints.Add(p4);

            foreach (var point in listPoints)
            {
                point.Draw();
            }

            Console.Read();
        }

    }
}
