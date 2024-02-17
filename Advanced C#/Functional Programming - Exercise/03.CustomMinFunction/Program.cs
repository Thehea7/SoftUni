namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main()
        {
            Func<IEnumerable<int>, int> smallestNumber = x => x.Min();

            Console.WriteLine(smallestNumber(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)));
        }
    }
}