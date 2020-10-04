using System;

namespace snake
{
    internal class FoodCreator
    {
        private  int _mapWidth;
        private  int _mapHeight;
        private  char _food;
        private  Random _rnd = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char food)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _food = food;
        }

        public Point CreateFood()
        {
            int x = _rnd.Next(2, _mapWidth - 2);
            int y = _rnd.Next(2, _mapHeight - 2);
            return new Point(x, y, _food);
        }


    }
}
