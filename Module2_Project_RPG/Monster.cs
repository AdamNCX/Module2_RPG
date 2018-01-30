namespace Module2_Project_RPG
{
    class Monster
    {
        public static int Health { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public static int Damage { get; set; }

        public Monster(string mName, int mHealth, int mLevel, int mDamage)
        {

            Health = mHealth;
            Name = "Spookm's The Terrifying";
            Level = 10;
            Damage = 5;

        }
        public void Attack(string target)
        {
            System.Console.WriteLine("Spookm's looks at {0} fiercly and swings his massive dildo for {1} damage!", target, Damage);
            if (target == "Archer")
            {
                //Reduce archer object health by damage(5).              

            }
        }
        public string ShowAll()
        {
            string s = "";
            s += "Villain Name: " + Name + "\n"
                + "Max HP: " + Health + "\n"
                + "Level: " + Level + "\n"
                + "Damage: " + Damage + "\n";
            return s;
        }
    }
}
