using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Map
    {
        string[,] gameMap;
        string[,] enemiesOnMap;
        int mapWidth;
        int mapHeight;
        Random rnd = new Random();

        public int randomRoll(int min, int max)
        {
            return rnd.Next(min, max);
        }

        public Map(int widthMin, int widthMax, int heightMin, int heightMax)
        {
            mapHeight = randomRoll(heightMin, heightMax);
            mapWidth = randomRoll(widthMin, widthMax);

            gameMap = new string[mapWidth, mapHeight];
        }
        public void initializeMap()
        {
            for (int coll = 0; coll < gameMap.GetLength(0); coll++)
            {
                for (int row = 0; row < gameMap.GetLength(1); row++)
                {
                    gameMap[coll, row] = ".";
                }
            }
           
        }

        

    }
}
