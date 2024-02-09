using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] insystem = Console.ReadLine().Split(",");
            string[] inFile = Console.ReadLine().Split(new[] { '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            foreach (var s in inFile)
            {
                if (!insystem.Contains(s))
                {
                    result.Append($"{s},");
                }
            }

            Console.WriteLine(result);
            //string[] output = inFile.Intersect(insystem).ToArray();

            //Console.WriteLine(string.Join(",", output));
        }
    }
}