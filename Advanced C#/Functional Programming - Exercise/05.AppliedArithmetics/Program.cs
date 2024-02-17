using System.Text;
using System.Threading.Channels;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = ReadInput();
            
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            Func<int, int> doMath = x => x;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(input);
                    continue;
                }
                if (command == "add")
                {
                    doMath= x => x + 1;
                }
                if (command == "multiply")
                {
                    doMath= x => x * 2;
                }
                if (command == "subtract")
                {
                    doMath= x => x - 1;
                }

                input = input.Select(doMath).ToList();
            }

        }

        private static List<int> ReadInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

    }
}