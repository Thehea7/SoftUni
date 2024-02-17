namespace _01._Action_Print
{
    internal class Program
    {
        static void Main()
        {
            Action<string> print = x => Console.WriteLine(x);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}