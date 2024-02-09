using System.IO;
using System.Linq;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int letters = lines[i].Where(char.IsLetter).Count();
                int punctuations = lines[i].Where(char.IsPunctuation).Count();

                lines[i] = $"Line {i+1}: {lines[i]} ({letters})({punctuations})";
            }
            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
