using System;

namespace snake
{
    internal class FoodCreator
    {
        private readonly int _mapWidth;
        private readonly int _mapHeight;
        private readonly char _food;
        private readonly Random _rnd = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char food)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _food = food;
        }

        public Point CreateFood()
        {
            int x = _rnd.Next(4, _mapWidth - 4);
            int y = _rnd.Next(4, _mapHeight - 4);
            return new Point(x, y, _food);
        }

    }
}
