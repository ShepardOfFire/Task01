using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public abstract class Enemy : Character
    {
       

        public int randomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            int randomValue = random.Next(min, max);
            return randomValue;
        }

    }
}
