using System.Security.Cryptography.X509Certificates;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            int count = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                count++;
                int[] arguments = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int index1 = arguments.Min();
                int index2 = arguments.Max();
                

                if (arguments.Any(x => x < 0 || x >= input.Count) || index1 == index2)
                {
                    input.Insert(input.Count/2, $"-{count}a");
                    input.Insert(input.Count/2, $"-{count}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (input[index1] == input[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {input[index1]}!");
                    input.RemoveAt(index2);
                    input.RemoveAt(index1);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (!input.Any())
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}