namespace _5.OddTimes
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            int result = 0;
            foreach (int i in input)
            {
                result = result ^ i;
            }

            Console.WriteLine(result);
        }
    }
}