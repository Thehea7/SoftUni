namespace _03.MergingLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>(input1.Count + input2.Count);

            for (int i = 0; i < input1.Count && i < input2.Count; i++)
            {
                output.Add(input1[i]);
                output.Add(input2[i]);
            }

            if (input1.Count > input2.Count)
            {
                for (int i =input2.Count; i < input1.Count; i++)
                {
                    output.Add(input1[i]);
                }
            }
            else if (input1.Count < input2.Count)
            {
                for (int i = input1.Count; i < input2.Count; i++)
                {
                    output.Add(input2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));
            
        }
    }
}