namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (input.Length > 1)
            {
                int[] newArrey = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    newArrey[i] = input[i] + input[i + 1];

                }
                input = newArrey;
            }

            int sum = input[0];
            Console.WriteLine(sum);
        }

    }
}