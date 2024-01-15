using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Deamon
    {
        public Deamon(string name, int health, double damage)
        {
            Name = name;
            Helath = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Helath { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Helath} health, {Damage:f2} damage";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Regex helathPattern = new Regex(@"(?'health'[^0-9\+\-\*\/\.\s\,])");
            Regex damagePattern = new Regex(@"(?'damage'[\+|\-]*(\d+\.\d+)|[\+|\-]*(\d+))");
            Regex multiply = new Regex(@"(?'multiply'[\*\/])");

            List<string> input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            List<Deamon> deamons = new List<Deamon>();

            foreach (var name in input)
            {
                if (name.Contains(" "))
                {
                    continue;
                }

                int healt = default;
                StringBuilder deamonName = new StringBuilder();
                foreach (Match match in helathPattern.Matches(name))
                {
                    deamonName.Append(match);

                }

                foreach (var ch in deamonName.ToString())
                {
                    healt += ch;
                }

                double damage = default;
                foreach (Match number in damagePattern.Matches(name))
                {
                    damage += double.Parse(number.ToString());
                }
                foreach (Match digit in multiply.Matches(name))
                {
                    if (digit.Value == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                deamons.Add(new Deamon(name, healt, damage));
            }

            foreach (var deamon in deamons.OrderBy(x => x.Name))
            {
                Console.WriteLine(deamon);
            }
        }
    }
}