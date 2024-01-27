namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> count = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in input)
            {
                if (!count.ContainsKey(s))
                {
                    count.Add(s, 0);
                }
                count[s]++;
            }

            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}