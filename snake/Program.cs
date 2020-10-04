using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    internal class Program
    {

        private static void Main()
        {
            Console.SetWindowSize(62, 22);
            Console.SetBufferSize(62, 22);

            #region wrap

            HorisontalLine upLine = new HorisontalLine(0,60,0,'+');
            upLine.Draw();
            HorisontalLine downLine = new HorisontalLine(0, 60, 20, '+');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0,0,20,'+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(60, 0, 20, '+');
            rightLine.Draw();

            #endregion

            Point p1 = new Point(2, 2, '*');

            Snake snake = new Snake(p1, 3, Direction.RIGHT);
            snake.Draw();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.Read();
        }

    }
}
