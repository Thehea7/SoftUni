namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            //string folderPath = @"..\..\..\Files\TestFolder";
            //string outputPath = @"..\..\..\Files\output.txt";

            string folderPath = @"..\..\..\..\..\..\";
            string outputPath = @"..\..\..\";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long bytes = ReadFolder(folderPath);
            Console.WriteLine($"{bytes/1024} KB");

        }

        public static long ReadFolder(string folderPath)
        {
            long size = 0;
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }
            string[] directories = Directory.GetDirectories(folderPath);

            foreach (string directory in directories)
            {
               size += ReadFolder(directory);
            }

            return size;
        }
    }
}
