using System.Diagnostics;

namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> output = new Queue<int>();

            while (input.Count != 0)
            {
                int number = input.Dequeue();
                if (number % 2 == 0)
                {
                    output.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}