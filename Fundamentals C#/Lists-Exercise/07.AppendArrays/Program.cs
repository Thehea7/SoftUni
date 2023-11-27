namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<string> output = new List<string>();

            for (int i = input.Length -1; i >= 0; i--)
            {
                string[] currentArr = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                output.AddRange(currentArr);
            }
            
            Console.WriteLine(string.Join(" ", output));
        }
    }
}