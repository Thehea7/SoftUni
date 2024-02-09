namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (writer)
            {
                using (reader1)
                {
                    using (reader2)
                    {
                        while (!reader1.EndOfStream && !reader2.EndOfStream)
                        {
                            writer.WriteLine(reader1.ReadLine());
                            writer.WriteLine(reader2.ReadLine());
                        }

                        while (!reader1.EndOfStream)
                        {
                            writer.WriteLine(reader1.ReadLine());
                        }

                        while (!reader2.EndOfStream)
                        {
                            writer.WriteLine(reader2.ReadLine());
                        }
                    }
                }
            }
            
        }
    }
}