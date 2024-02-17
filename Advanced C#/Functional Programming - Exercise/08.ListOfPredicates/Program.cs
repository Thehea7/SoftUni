using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main()
        {
            int end = int.Parse(Console.ReadLine());
            
            List<int> conditions = ReadConditions();

            List<int> output = Filter(end, conditions);

            Console.WriteLine(string.Join(" ", output));
            
            
        }

        private static List<int> ReadConditions()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        private static List<int> Filter(int n, List<int> conditions)
        {
            
            List<int> output = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (conditions.TrueForAll(x => i % x ==0))
                {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}