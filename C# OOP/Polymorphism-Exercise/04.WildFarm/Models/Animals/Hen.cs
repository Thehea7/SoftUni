using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            Diet = new List<string>() { "Meat", "Vegetable", "Fruit", "Seeds" };
            portionWeight = 0.35;
        }

        public override string AskForFood()
        {
            return "Cluck";
        }
    }
}
