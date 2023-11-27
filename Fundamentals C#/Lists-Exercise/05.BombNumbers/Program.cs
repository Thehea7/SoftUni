namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> conditions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bomb = conditions[0];
            int power = conditions[1];

            while (input.Contains(bomb))
            {

                int index = input.FindIndex(x => x == bomb) - power;
                int count = power * 2 + 1;
                if (index  < 0) index = 0;
                if (index + count >= input.Count) count = input.Count - index;
                input.RemoveRange(index, count);
            }

            Console.WriteLine(input.Sum());
        }
    }
}