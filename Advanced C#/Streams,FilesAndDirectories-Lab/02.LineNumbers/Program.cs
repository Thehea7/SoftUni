namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int count = 1;
            using (reader)
            {
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = $"{count}. {reader.ReadLine()}";
                        writer.WriteLine(line);
                        count++;

                    }
                }
            }

        }
    }
}