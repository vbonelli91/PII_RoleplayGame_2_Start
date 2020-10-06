using System.Collections;
using System;
using System.Collections.Generic;


namespace RoleplayGame
{
    /*
        Se aplicó el patrón Creator en el momento en el cual en vez de pasar los items como parámetros, 
        los creamos dentro del mismo constructor.
    */
    public class Knight:ICharacter
    {
         
        private int health=100;



        public Knight(string name)
        {
            this.Name = name;
            this.Sword = new Sword();
            this.Shield = new Shield();
            this.Armor = new Armor();
        }

        public string Name { get; set; }


        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public int AttackValue
        {
            get
            {
                return Sword.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

    }
}