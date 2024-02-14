using System.Security.Cryptography.X509Certificates;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main()
        {
            Func<string, int> parse = Parse;/*  x => int.Parse(x);  */

            int[] array = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parse)
                .ToArray();

            SolveProblem solve = PrintCount;
            solve += PrintSum;

            solve(array);
        }

        public static int Parse(string x)
        {
            return int.Parse(x);
        }

        public delegate void SolveProblem(int[] array);
        public static void PrintCount(int[] array)
        {
            Console.WriteLine(array.Length);
        }
        public static void PrintSum(int[] array)
        {
            Console.WriteLine(array.Sum());
        }
    }
}

