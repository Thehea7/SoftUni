using _04_WildFarm.Factories.Interfaces;
using _04_WildFarm.Models.Animals;
using _04_WildFarm.Models.Animals.AbstractClasess;
using _04_WildFarm.Models.Animals.Interfaces;

namespace _04_WildFarm.Factories
{
    public class Factory : IFactory
    {
        public IAnimal CreateAnimal(string[] input)
        {
            string type = input[0];
            string name = input[1];
            double weight = double.Parse(input[2]);

            switch (type)
            {
                case "Hen":
                case "Owl":
                    return CreateBird(type, name, weight, input);
                case "Cat":
                case "Tiger":
                    return CreateFeline(type, name, weight, input);
                case "Dog":
                case "Mouse":
                    return CreateMammal(type, name, weight, input);
                default:
                    throw new ArgumentException("Animal type should be Hen, Owl, Mouse, Cat, Dog or Tiger");
            }
        }

        private Mammal CreateMammal(string type, string name, double weight, string[] input)
        {
            string livingRegion = input[3];
            if (type == "Dog")
                return new Dog(name, weight, livingRegion);
            return new Mouse(name, weight, livingRegion);
        }

        private Feline CreateFeline(string type, string name, double weight, string[] input)
        {
            string livingRegion = input[3];
            string breed = input[4];
            if (type == "Cat")
                return new Cat(name, weight, livingRegion, breed);
            return new Tiger(name, weight, livingRegion, breed);
        }

        private Bird CreateBird(string type, string name, double weight, string[] input)
        {
            double wingSize = double.Parse(input[3]);
            if (type == "Hen")
                return new Hen(name, weight, wingSize);

            return new Owl(name, weight, wingSize);
        }
    }
}
