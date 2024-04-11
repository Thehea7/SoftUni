using _04_WildFarm.IO.Interfaces;

namespace _04_WildFarm.IO
{
    public class FileWriter : IWriter
    {
        private string filePath = "../../../result.txt";
        public void WriteLine(object obj)
        {
            using StreamWriter writer = new(filePath, true);
            writer.WriteLine(obj);
        }

        public void Write(object obj)
        {
            using StreamWriter writer = new(filePath, true);
            writer.Write(obj);
        }
    }
}
