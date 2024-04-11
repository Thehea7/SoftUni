using _04_WildFarm.IO.Interfaces;

namespace _04_WildFarm.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }

        public void Write(object obj)
        {
            Console.Write(obj);
        }
    }
}
