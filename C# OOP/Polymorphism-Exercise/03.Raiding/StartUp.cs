using _03_Raiding.Core;
using _03_Raiding.Core.Interfaces;
using _03_Raiding.Factories;
using _03_Raiding.Factories.Interfaces;
using _03_Raiding.IO;
using _03_Raiding.IO.Interfaces;

namespace _03_Raiding
{
    public class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IFactory factory = new Factory();
            IEngine engine = new Engine(reader, writer, factory);

            engine.Run();
        }
    }
}
