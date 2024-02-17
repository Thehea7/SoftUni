namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = ReadAndReverse();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> filter = x => x % n != 0;
            Console.WriteLine(string.Join(" ", input.Where(filter)));
        }

        private static List<int> ReadAndReverse()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();
        }
    }
}