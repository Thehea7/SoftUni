using _04_WildFarm.Models.Animals.AbstractClasess;

namespace _04_WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            Diet = new List<string>() { "Meat" };
            portionWeight = 1;
        }

        public override string AskForFood()
        {
            return "ROAR!!!";
        }
    }
}
