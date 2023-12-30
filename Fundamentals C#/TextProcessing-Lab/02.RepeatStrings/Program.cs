using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder output = new StringBuilder();
            foreach (var s in input)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    output.Append(s);
                }
            }
            Console.WriteLine(output);
        }
    }
}