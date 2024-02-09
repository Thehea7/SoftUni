using System.Text;

namespace LabTest4_FileStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"../../../input.txt";
            string outputFilePath = @"../../../output.txt";

            FileStream stream = new FileStream(inputFilePath, FileMode.Open);
            StreamWriter writer = new StreamWriter(outputFilePath);

            byte[] buffer = new byte[2];

            while (stream.Position < stream.Length)
            {
                stream.Read(buffer, 0, buffer.Length);

                string input = Encoding.UTF8.GetString(buffer);

                //Console.WriteLine(string.Join(",", buffer));
                Console.Write(input);
               // writer.Write(input);
                Thread.Sleep(100);
            }
        }
    }
}