﻿using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Wizard gandalf = new Wizard("Gandalf");
            

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
