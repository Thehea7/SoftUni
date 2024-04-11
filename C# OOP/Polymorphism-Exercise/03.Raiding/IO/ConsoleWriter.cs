
using _03_Raiding.IO.Interfaces;

namespace _03_Raiding.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public void Write(string str)
        {
            Console.Write(str);
        }
    }
}
