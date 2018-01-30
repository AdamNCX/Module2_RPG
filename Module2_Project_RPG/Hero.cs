using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Project_RPG
{
    public class Hero
    {
        public string Name { get; set; }
        private string ClassName { get; set; }
        protected static int Health { get; set; }
        public static int Mana { get; set; }
        public static int Level { get; set; }
        public int Damage { get; set; }

        public Hero(string hName, string hClass, int hHealth, int hMana, int hLevel, int hDamage)
        {
            Name = hName;
            ClassName = hClass;
            Health = hHealth;
            Mana = hMana;
            Level = 1;
            Damage = hDamage;
        }
        public void CastSpell(int damage = 5)
        {
            Monster.Health -= damage;
        }
        public void MeleeAttack(int damage = 5)
        {
            Monster.Health -= damage;
        }
        public void ShootArrow(int damage = 5)
        {
            Monster.Health -= damage;
        }
        public string ShowAll()
        {
            string s = "";
            s += "Hero Name: " + Name + "\n"
                + "Hero Class: " + ClassName + "\n"
                + "Hero Max HP: " + Health + "\n"
                + "Hero Max MP: " + Mana + "\n"
                + "Hero Level: " + Level + "\n"
                + "Hero Damage:" + Damage + "\n";
            return s;
        }
    }
}
