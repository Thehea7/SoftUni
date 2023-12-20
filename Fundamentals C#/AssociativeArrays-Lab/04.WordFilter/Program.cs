namespace _04.WordFilter
{
    internal class Program
    {
        static void Main()
        {
            //string[] input = Console.ReadLine()
            //    .Split()
            //    .Where(x => x.Length % 2 == 0)
            //    .ToArray();


            Console.WriteLine(string.Join("\n", Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray()));
        }
    }
}