using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            Diet = new List<string>() { "Meat" };
            portionWeight = 0.25;
        }

        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
