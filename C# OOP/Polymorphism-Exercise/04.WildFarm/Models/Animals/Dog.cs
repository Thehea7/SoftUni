using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            Diet = new List<string>() { "Meat" };
            portionWeight = 0.4;
        }

        public override string AskForFood()
        {
            return "Woof!";
        }
    }
}
