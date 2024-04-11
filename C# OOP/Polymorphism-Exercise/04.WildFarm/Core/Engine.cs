using _04_WildFarm.Core.Interfaces;
using _04_WildFarm.Factories.Interfaces;
using _04_WildFarm.IO.Interfaces;
using _04_WildFarm.Models.Animals.Interfaces;
using _04_WildFarm.Models.Food;
using _04_WildFarm.Models.Food.Interfaces;

namespace _04_WildFarm.Core
{
    public class Engine :IEngine
    {

        private IReader reader;
        private IWriter writer;
        public IFactory factory;
        public Engine(IReader reader, IWriter writer, IFactory factory)
        {
            this.reader = reader;
            this.writer = writer;
            this.factory = factory;
        }
        
        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();
            string input;
            while ((input = reader.Readline()) != "End")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    IAnimal animal = factory.CreateAnimal(arguments);
                    animals.Add(animal);
                    IFood food = CreateFood();
                    writer.WriteLine(animal.AskForFood());
                    animal.Feed(food);
                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }
            }

            animals.ForEach(x => writer.WriteLine(x));

        }

        private IFood CreateFood()
        {
            string[] foodInfo = reader.Readline().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);
            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("You can only create Vegetable, Fruit, Meat or Seeds");
            }
        }
    }
}
