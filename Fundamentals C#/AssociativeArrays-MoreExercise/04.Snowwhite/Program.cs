using System.Collections.Generic;
using System.Drawing;

namespace _03.Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Power { get; set; }

        public int ColorPower { get; set; }

        public void GetColorPower(Dictionary<string, int> colorsPower)
        {
            ColorPower = colorsPower[Color];
        }

        public Dwarf(string name, string color, int power)
        {
            Name = name;
            Color = color;
            Power = power;
        }

        public override string ToString()
        {
            return $"({Color}) {Name} <-> {Power}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> colorsPower = new Dictionary<string, int>();
            List<Dwarf> dwarves = new List<Dwarf>();

            string command;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] arguments = command.Split(" <:> ");
                string name = arguments[0];
                string color = arguments[1];
                int power = int.Parse(arguments[2]);
                Dwarf dwarf = new Dwarf(name, color, power);



                if (dwarves.Exists(x => x.Color == color && x.Name == name))
                {
                    int index = dwarves.FindIndex(x => x.Color == color && x.Name == name);
                    if (dwarves[index].Power < power)
                    {
                        dwarves[index].Power = power;
                    }
                }
                else
                {
                    dwarves.Add(dwarf);
                    if (!colorsPower.ContainsKey(color))
                    {
                        colorsPower.Add(color, 0);
                    }
                    colorsPower[color]++;
                }
            }

            foreach (var dwarf1 in dwarves)
            {
                dwarf1.GetColorPower(colorsPower);
            }

            dwarves = dwarves.OrderByDescending(dwarf => dwarf.Power).ThenByDescending(x => x.ColorPower).ToList();

            foreach (var dwarf in dwarves)
            {
                Console.WriteLine(dwarf);
            }
        }
    }
}