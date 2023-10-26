namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int even = 0;
            int odd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    even += input[i];
                }
                else
                {
                    odd += input[i];
                }
            }
            Console.WriteLine(even - odd);
        }
    }
}