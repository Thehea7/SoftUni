
namespace _01.Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            RunVehicles();
            //RunVehiclesExtensions();
        }

        private static void RunVehicles()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            // IWriter writer = new FileWriter();  // Use this "writer" to write result in File
            IVehicleFactory vehicleFactory = new VehicleFactory();
            IEngine engine = new Engine(reader, writer, vehicleFactory);
            engine.Run();
        }
        private static void RunVehiclesExtensions()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            // IWriter writer = new FileWriter(); // Use this "writer" to write result in File

            IVehicleFactory vehicleFactory = new VehicleFactory_02();

            IEngine engine = new Engine_02(reader, writer, vehicleFactory);

            engine.Run();
        }
    }
}
