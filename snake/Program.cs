using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Console.SetWindowSize(62, 22);
            Console.SetBufferSize(62, 22);

            Point p1 = new Point(2, 2, '*');

            Snake snake = new Snake(p1,3,Direction.RIGHT);
            snake.Draw();

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
