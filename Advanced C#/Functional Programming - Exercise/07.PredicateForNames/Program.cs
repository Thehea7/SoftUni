namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Func<string, bool> filter = x => x.Length <= length;

            Console.WriteLine(string.Join("\n", input.Where(filter)));

        }
    }
}