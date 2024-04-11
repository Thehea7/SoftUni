using _04_WildFarm.Core;
using _04_WildFarm.Core.Interfaces;
using _04_WildFarm.Factories;
using _04_WildFarm.Factories.Interfaces;
using _04_WildFarm.IO;
using _04_WildFarm.IO.Interfaces;

namespace _04_WildFarm
{
    public class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            //IWriter writer = new FileWriter();
            IFactory factory = new Factory();
            IEngine engine = new Engine(reader, writer, factory);

            engine.Run();
        }
    }
}
