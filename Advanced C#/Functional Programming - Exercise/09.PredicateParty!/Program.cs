using System.Text;
using System.Threading.Channels;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] arguments = command.Split();
                string filterType = arguments[0];
                string condition = arguments[1];
                string argument = arguments[2];

                Func<string, bool> predicate = CreateFilter(condition, argument);
                
                input = AplpyFilter(input, predicate, filterType);
            }

            Console.WriteLine(input.Any()
            ? $"{string.Join(", ", input)} are going to the party!"
            : "Nobody is going to the party!");
        }
        
        private static List<string> AplpyFilter(List<string> input, Func<string, bool> predicate, string filterType)
        {
            List<string> output = new List<string>();
            if (filterType == "Double")
            {
                foreach (var name in input)
                {
                    output.Add(name);
                    if (predicate(name))
                    {
                        output.Add(name);
                    }
                }
            }

            if (filterType == "Remove")
            {
                output = input.Where(x => predicate(x) == false).ToList();
            }

            return output;
        }

        private static Func<string, bool> CreateFilter(string condition, string argument)
        {
            if (condition == "StartsWith")
            {
                return x => x.StartsWith(argument);
            }

            if (condition == "EndsWith")
            {
              return  x => x.EndsWith(argument);
            }

            if (condition == "Length")
            {
                return x => x.Length == int.Parse(argument);
            }

            return default;
        }
    }
}