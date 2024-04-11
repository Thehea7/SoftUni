using _04_WildFarm.Models.Animals.Interfaces;

namespace _04_WildFarm.Factories.Interfaces
{
    public interface IFactory
    {
        public IAnimal CreateAnimal(string[] input);
    }
}
