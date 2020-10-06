using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class ExampleTest
    {
        
        [Test]
        public void Test_total_damage_wizard()
        {
        Wizard gandalf = new Wizard("Gandalf");
        int totalDmgGandalf = gandalf.AttackValue;
        Assert.AreEqual(170, totalDmgGandalf);
        }

        [Test]
        public void Test_total_defense_wizard()
        {
            Wizard gandalf = new Wizard("Gandalf");
            int totalDefGandalf = gandalf.DefenseValue;
            Assert.AreEqual(170, totalDefGandalf);
        }

        [Test]
        public void Test_total_damage_dwarf()
        {
        Dwarf gimli = new Dwarf("Gimli");
        int totalDmgGimli = gimli.AttackValue;
        Assert.AreEqual(25, totalDmgGimli);
        }

        [Test]
        public void Test_total_defense_dwarf()
        {
            Dwarf gimli = new Dwarf("Gimli");
            int totalDefGimli = gimli.DefenseValue;
            Assert.AreEqual(32, totalDefGimli);
        }

        [Test]
        public void Test_total_damage_archer()
        {
        Archer legolas = new Archer("Legolas");
        int totalDmgLegolas = legolas.AttackValue;
        Assert.AreEqual(15, totalDmgLegolas);
        }

        [Test]
        public void Test_total_defense_archer()
        {
            Archer legolas = new Archer("Legolas");
            int totalDefLegolas = legolas.DefenseValue;
            Assert.AreEqual(18, totalDefLegolas);
        }

        [Test]
        public void Test_total_damage_knight()
        {
        Knight arturo = new Knight("Arturo");
        int totalDmgArturo = arturo.AttackValue;
        Assert.AreEqual(20, totalDmgArturo);
        }

        [Test]
        public void Test_total_defense_knight()
        {
            Knight arturo = new Knight("Arturo");
            int totalDefArturo = arturo.DefenseValue;
            Assert.AreEqual(39, totalDefArturo);
        }
        [Test]
        public void Test_attack()
        {
            Wizard gandalf = new Wizard("Gandalf");
            Dwarf gimli = new Dwarf("Gimli");

            gimli.ReceiveAttack(gandalf.AttackValue);

            int healthAfterAttack = gimli.Health;

            Assert.AreEqual(0, healthAfterAttack);
        }
    }


}