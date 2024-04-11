using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            Diet = new List<string>() { "Meat", "Vegetable" };
            portionWeight = 0.3;
        }

        public override string AskForFood()
        {
            return "Meow";
        }
    }
}
