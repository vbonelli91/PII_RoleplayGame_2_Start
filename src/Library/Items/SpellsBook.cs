using System.Collections.Generic;

namespace RoleplayGame
{
    /*
        Se aplicó el patrón Creator en el momento en el cual en vez de pasar los "Spells" como parámetros, 
        los creamos dentro del mismo constructor.
    */
    public class SpellsBook : MagicItems
    {
        public Spell[] Spells { get; set; }
        public SpellsBook()
        {
            this.Spells = new Spell[]{ new Spell() };
        }
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}