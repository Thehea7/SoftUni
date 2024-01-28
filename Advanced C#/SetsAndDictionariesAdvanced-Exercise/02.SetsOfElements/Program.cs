namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main()
        {
            int[] entries = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstSetLenght = entries[0];
            int secondSetlenght = entries[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < secondSetlenght; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }


            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}