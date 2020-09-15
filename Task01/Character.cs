using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public abstract class Character
    {
        int hp;
        int maxHp;
        int damage;     
        string[,] vision;

        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Damage { get => damage; set => damage = value; }
        public string[,] Vision { get => vision; set => vision = value; }


        public enum Movement
        { 
            NoMovement,
            Up,
            Down,
            Left,
            Right
        }

        //constructor
        //public Character()
        //{
        //    this.Hp = 100;
        //    this.MaxHp = 100;
        //    this.Damage = 15;
        //}



        //method
        public virtual void Attack()
        {

        }



        //public bool IsDead()
        //{

        //}

        //public virtual bool CheckRange()
        //{

        //}

        public void Move()
        {

        }



    }
}
