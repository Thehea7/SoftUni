using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace _02.Race
{
    internal class Program
    {
        static void Main()
        {
            string[] participantsNames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Dictionary<string, int> participants = new Dictionary<string, int>();

            string input;
            int count = 0;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;
                int distance = default;

                foreach (var ch in input)
                {
                    if (char.IsDigit(ch))
                    {
                        distance += int.Parse(ch.ToString());
                    }
                    else if (char.IsLetter(ch))
                    {
                        name += ch;
                    }
                }

                if (participantsNames.Contains(name))
                {
                    if (!participants.ContainsKey(name))
                    {
                        participants.Add(name, distance);
                        count++;
                    }
                    else
                    {
                        participants[name] += distance;
                    }

                }
            }

            Dictionary<string, int> orderedDictionary = participants.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            List<string> orderedNames = new List<string>();
            foreach (var name in orderedDictionary)
            {
                orderedNames.Add(name.Key);
            }

            Console.WriteLine($"1st place: {orderedNames[0]}");
            Console.WriteLine($"2nd place: {orderedNames[1]}");
            Console.WriteLine($"3rd place: {orderedNames[2]}");
        }
    }
}