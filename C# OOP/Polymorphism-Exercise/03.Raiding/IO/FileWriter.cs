using _03_Raiding.IO.Interfaces;

namespace _03_Raiding.IO
{
    public class FileWriter : IWriter
    {
        private string filePath = "../../../result.txt";
        public void WriteLine(string str)
        {
            using StreamWriter writer = new(filePath, true);
            writer.WriteLine(str);
        }

        public void Write(string str)
        {
            using StreamWriter writer = new(filePath, true);
            writer.Write(str);
        }
    }
}
