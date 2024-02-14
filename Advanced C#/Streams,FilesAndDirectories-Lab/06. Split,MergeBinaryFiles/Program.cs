namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] firstPart = default(byte[]);
            byte[] secondPart = default(byte[]);


            using (FileStream origin = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] png = new byte[origin.Length];
                origin.Read(png, 0, png.Length);


                if (png.Length % 2 == 0)
                {
                    firstPart = new byte[png.Length / 2];
                    secondPart = new byte[png.Length / 2];
                }
                else
                {
                    firstPart = new byte[png.Length / 2 + 1];
                    secondPart = new byte[png.Length / 2];
                }

                for (int i = 0; i < firstPart.Length; i++)
                {
                    firstPart[i] = png[i];
                }
                for (int i = firstPart.Length, k =0; i < png.Length; i++, k++)
                {
                    secondPart[k] = png[i];
                }

                using (FileStream stream1 = new FileStream(partOneFilePath, FileMode.Create))
                {
                    using (FileStream stream2 = new FileStream(partTwoFilePath, FileMode.Create))
                    {
                        stream1.Write(firstPart, 0, firstPart.Length);
                        stream2.Write(secondPart, 0, secondPart.Length);
                    }
                }
            }
                
          
            
            

        }
        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream stream1 = new FileStream(partOneFilePath, FileMode.Open))
            {
                using(FileStream stream2 = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    using (FileStream writer = new FileStream(joinedFilePath, FileMode.Append))
                    {
                        byte[] file1 = new byte[stream1.Length];
                        byte[] file2 = new byte[stream2.Length];

                        stream1.Read(file1, 0, file1.Length);
                        stream2.Read(file2, 0, file2.Length);
                        writer.Write(file1, 0, file1.Length);
                        writer.Write(file2 , 0, file2.Length);
                    }
                }
            }
        }
    }
}