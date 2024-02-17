using System.Security.Cryptography.X509Certificates;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = ReadBounderies();
            string filtertype = Console.ReadLine();
           // Func<int, bool> filter = Filter(filtertype);
            Predicate<int> predicate = i => true;   // remove to use option2
            if (filtertype == "odd")                // remove to use option2
              predicate=  x => x % 2 != 0;      // remove to use option2
            if (filtertype == "even")               // remove to use option2
                predicate = x => x % 2 == 0;    // remove to use option2

            Console.WriteLine(string.Join(" ", input.Where(x => predicate(x)))); // remove to use option2
            //Console.WriteLine(string.Join(" ", input.Where(filter)));
        }

        private static List<int> ReadBounderies()
        {
            int[] bounderies = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = bounderies[0];
            int end = bounderies[1];

            List<int> input = new List<int>();
            for (int i = start; i <= end; i++)
            {
                input.Add(i);
            }

            return input;
        }

        //private static Func<int, bool> Filter(string filter)
        //{
        //    if (filter == "odd")
        //        return x => x % 2 != 0;
        //    if (filter == "even")
        //        return x => x % 2 == 0;

        //    return null;
        //}
    }

}