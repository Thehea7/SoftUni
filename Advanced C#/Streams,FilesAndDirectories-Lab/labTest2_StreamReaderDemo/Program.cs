using System.IO;

namespace labTest2_StreamReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\..\\Program.cs");
            StreamWriter write = new StreamWriter("..\\..\\..\\Output.txt");
            int count = 1;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine($"{count}. {line}");
                write.WriteLine(line);
                count++;
            }
            reader.Close();
            write.Close();
        }
    }
}