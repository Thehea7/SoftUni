namespace TestLab_Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory.CreateDirectory(@"../../../SecondFolder");

            string[] subDirs = Directory.GetDirectories(@"..\..\..\NewFolder");

            foreach (var subDir in subDirs)
            {
                Directory.Move(subDir, subDir.Replace("NewFolder", "SecondFolder"));
            }
        }
    }
}