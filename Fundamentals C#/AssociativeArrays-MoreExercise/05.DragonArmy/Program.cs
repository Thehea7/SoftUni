namespace _05.DragonArmy
{
    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public override string ToString()
        {
            return $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int damage = default;
                int health = default;
                int armor = default;
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else { damage = int.Parse(input[2]); }
                if (input[3] == "null")
                {
                    health = 250;
                }
                else { health = int.Parse(input[3]); }
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else { armor = int.Parse(input[4]); }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                }

                if (!dragons[type].Exists(x => x.Name == name))
                {
                    dragons[type].Add(new Dragon(name, damage, health, armor));
                }

                int index = dragons[type].FindIndex(x => x.Name == name);
                dragons[type][index].Damage = damage;
                dragons[type][index].Health = health;
                dragons[type][index].Armor = armor;
            }

            foreach (var dragon in dragons)
            {
                double averageDamage = dragon.Value.Average(x => x.Damage);
                double averageHealth = dragon.Value.Average(x => x.Health);
                double averageArmor = dragon.Value.Average(x => x.Armor);

                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon1 in dragon.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine(dragon1);
                }
            }


        }
    }
}