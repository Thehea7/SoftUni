using System.Linq;

namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] chars = new[] { '-', ',', '.', '!', '?' };


            StringBuilder output = new StringBuilder();
            int count = 0;

            using StreamReader reader = new StreamReader(inputFilePath);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (count % 2 == 0)
                {
                    foreach (var c in line)
                    {
                        if (chars.Contains(c))
                        {
                            line = line.Replace(c, '@');
                        }
                    }
                    string[] reversedLineArray = line.Split(' ').Reverse().ToArray();
                    string reversedLine = String.Join(" ", reversedLineArray);
                    output.AppendLine($"{reversedLine}");
                }
                count++;
            }


            return output.ToString();
        }
    }
}
