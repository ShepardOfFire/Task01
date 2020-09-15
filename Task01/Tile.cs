using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public abstract class Tile
    {
        //variables
        protected int X;
        protected int Y;

        public int x { get => X; set => X = value; }
        public int y { get => Y; set => Y = value; }

        public enum TileType
        { 
            Hero,
            Enemy,
            Gold,
            Weapon
        }

       // Constructer

        public Tile()
        {
            x = 1;
            y = 1;
        }

    }


  






}
