namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (reader)
            {
                using (writer)
                {
                    int count =0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (count % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                    }
                }
            }
        }
    }
}