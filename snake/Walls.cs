using System.Collections.Generic;

namespace snake
{

    /// <summary>
    /// 
    /// </summary>
    public class Walls
    {
        private readonly List<Figure> _wallList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapWidth"></param>
        /// <param name="mapHeight"></param>
        public Walls(int mapWidth, int mapHeight)
        {
            _wallList = new List<Figure>();

            HorisontalLine upLine = new HorisontalLine(1, mapWidth - 1, 1, '-');
            HorisontalLine downLine = new HorisontalLine(1, mapWidth - 1, mapHeight + 1, '-');
            VerticalLine leftLine = new VerticalLine(1, 2, mapHeight, '|');
            VerticalLine rightLine = new VerticalLine(mapWidth - 1, 2, mapHeight, '|');

            _wallList.Add(upLine);
            _wallList.Add(downLine);
            _wallList.Add(leftLine);
            _wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Figure wall in _wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Draw()
        {
            foreach (Figure wall in _wallList)
            {
                wall.Draw();
            }
        }
    }
}
