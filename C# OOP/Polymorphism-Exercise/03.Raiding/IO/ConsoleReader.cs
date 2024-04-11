using _03_Raiding.IO.Interfaces;

namespace _03_Raiding.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
           return Console.ReadLine();
        }

       
    }
}
