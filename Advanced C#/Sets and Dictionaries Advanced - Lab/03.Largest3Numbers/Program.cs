namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}