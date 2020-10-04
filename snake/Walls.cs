using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    public class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorisontalLine upLine = new HorisontalLine(1, mapWidth-1, 1, '-');
            HorisontalLine downLine = new HorisontalLine(1, mapWidth-1, mapHeight+1, '-');
            VerticalLine leftLine = new VerticalLine(1, 2, mapHeight, '|');
            VerticalLine rightLine = new VerticalLine(mapWidth-1, 2, mapHeight, '|');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
