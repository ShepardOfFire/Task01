using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Hero : Character
    {
        public Hero()
        {
            this.Damage = 2;
        }

        public void MyString()
        {
            Console.WriteLine("Hero HP = " + this.Hp);
            Console.WriteLine("Hero Damage = " + this.Damage);
        }
    }
}
