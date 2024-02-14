namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main()
        {
            Predicate<string> checker = word => char.IsUpper(word[0]);
            // Func<string, bool> checker = word => char.IsUpper(word[0]);


            Console.WriteLine(string.Join("\n",
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => checker(x))));
        }
    }
}