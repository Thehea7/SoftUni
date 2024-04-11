using _04_WildFarm.IO.Interfaces;

namespace _04_WildFarm.IO
{
    public class ConsoleReader : IReader
    {
        public string Readline()
        {
           return Console.ReadLine();
        }
    }
}
