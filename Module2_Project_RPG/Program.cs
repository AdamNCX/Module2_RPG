using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Project_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int health = 25;
            int level = 1;
            int damage = 5;
            int mana = 50;
            //Character parameters: Name, Class, Health, Mana, Level, Damage
            Monster Spook = new Monster(name, 50, 0, health);
            Hero Archer = new Hero("Hawkeye", "Marksman", 40, 1, 30, 5);
            Hero Mage = new Hero("Wrath", "Mage", 25, 100, 1, 5);
            Hero Warrior = new Hero("Alphonse", "Warrior", 50, 1, mana, 5); //Has no mana

            Console.WriteLine("Welcome to the Ultra Megazord RPG of Epicness!!! ");
            Console.WriteLine("-----Meet Your Heros-----\n");
            Console.WriteLine(Archer.ShowAll() + "\n" + Warrior.ShowAll() + "\n" + Mage.ShowAll());

            Console.WriteLine("-----Meet Your Villain-----");
            Console.WriteLine(Spook.ShowAll());
            Console.WriteLine("{0} Health: {1}", Spook.Name, Monster.Health);
            Archer.ShootArrow();
            Console.WriteLine("{0} attacked Spookm's for {1} damage -- new HP: {2}.", Archer.Name, Archer.Damage, Monster.Health);            
            //Spook.Attack();
            Console.Read();
        }
    }
}
