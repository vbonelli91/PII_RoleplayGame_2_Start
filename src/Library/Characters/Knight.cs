using System.Collections;
using System;
using System.Collections.Generic;


namespace RoleplayGame
{
    public class Knight:ICharacter
    {
         
        private int health=100;

        public List <IItems> Items{get;set;} = new List<IItems>();

        public Knight(string name)
        {
            this.Name = name;
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

        public void AddItem(IItems item){
            this.Items.Add(item);

        }
    }
}