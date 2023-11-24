
namespace _01.SumAdjacentEqualNumbers

{
    internal class Program
    {
        static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count- 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] *= 2;
                    input.RemoveAt(i+1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
            
        }
    }
}