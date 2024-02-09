namespace TestLabEncryptFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Images";

            string[] file = Directory.GetFiles(folderPath);

            foreach (string fileItem in file)
            {
                EncryptFile(fileItem);
            }

            //EncryptFile($"{folderPath}//Schedule.png");
        }

       private static void EncryptFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);

                for (int i = 1; i < data.Length; i++)
                {
                    data[i] =(byte) (data[i] ^ 178);
                }

                stream.Seek(0, SeekOrigin.Begin);
                stream.Write(data, 0, data.Length);

                Console.WriteLine(string.Join(" ", data));
            }
        }
    }
}