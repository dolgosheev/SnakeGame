using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(62, 22);
            Console.SetWindowSize(62, 22);

            Point p1 = new Point(2, 2, '1');
            Point p2 = new Point(2, 4, '2');
            Point p3 = new Point(4, 2, '3');
            Point p4 = new Point(4, 4, '4');

            List<Point> listPoints = new List<Point>();
            
            listPoints.Add(p1);
            listPoints.Add(p2);
            listPoints.Add(p3);
            listPoints.Add(p4);

            foreach (var point in listPoints)
            {
                point.Draw();
            }

            HorisontalLine upLine = new HorisontalLine(0,60,0,'+');
            upLine.Draw();
            HorisontalLine downLine = new HorisontalLine(0, 60, 20, '+');
            downLine.Draw();



            VerticalLine leftLine = new VerticalLine(0,0,20,'+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(60, 0, 20, '+');
            rightLine.Draw();

            Console.Read();
        }

    }
}
