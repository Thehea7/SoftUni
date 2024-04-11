using _04_WildFarm.Models.Animals.Interfaces;
using _04_WildFarm.Models.Food.Interfaces;

namespace _04_WildFarm.Models.Animals.AbstractClasess
{
    public abstract class Animal : IAnimal
    {
        protected List<string> Diet;
        protected double portionWeight = 1;
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            Diet = new List<string>();
        }

        public abstract string AskForFood();

        public virtual void Feed(IFood food)
        {
            if (Diet.Contains(food.GetType().Name) == false)
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * portionWeight;
        }

    }
}
