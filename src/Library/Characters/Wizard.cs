using System.Collections;
using System;
using System.Collections.Generic;


namespace RoleplayGame
{
    public class Wizard:ICharacter
    {
        private int health = 100;

        public List <IItems> Items{get;set;} = new List<IItems>();
        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
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
