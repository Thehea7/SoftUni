using System.Reflection.PortableExecutable;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            FileStream stream = new FileStream(binaryFilePath, FileMode.Open);
            byte[] buffer = new byte[stream.Length];

            

            using (stream)
            {
                using (StreamReader reader = new StreamReader(bytesFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {

                        var bytes = reader.ReadToEnd();
                        int[] filter = bytes.Split("\n").Select(int.Parse).ToArray();
                        stream.Read(buffer, 0, buffer.Length);
                        // Console.WriteLine(string.Join(" ", buffer));
                         Console.WriteLine(string.Join(" ", filter));

                         foreach (var b in buffer)
                         {
                             if (filter.Contains(b))
                             {
                                 writer.Write($"{b} ", true);
                                // Console.Write($"{b} ", true);
                            }
                         }
                    }
                }
            }
        }
    }
}