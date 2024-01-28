using System.Threading.Channels;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int entries = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < entries; i++)
            {
                string[] commands = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string color = commands[0];
                string[] clothes = commands[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }
                    wardrobe[color][cloth]++;
                }
            }

            string[] filter = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string filterColor = filter[0];
            string filterClothes = filter[1];

            foreach (var (color, cloths) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (cloth, number) in cloths)
                {
                    Console.Write($"* {cloth} - {number}");
                    if (filterColor == color && filterClothes == cloth)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}