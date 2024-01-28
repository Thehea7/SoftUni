namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }

            foreach (var element in elements.OrderBy(x => x))
            {
                Console.Write($"{element} ");
            }
        }
    }
}