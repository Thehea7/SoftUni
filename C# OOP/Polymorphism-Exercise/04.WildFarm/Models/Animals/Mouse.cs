using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            Diet = new List<string>() { "Vegetable", "Fruit" };
            portionWeight = 0.1;
        }

        public override string AskForFood()
        {
            return "Squeak";
        }

        
    }
}
