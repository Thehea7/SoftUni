using _04_WildFarm.Models.Food.Interfaces;

namespace _04_WildFarm.Models.Food
{
    public class Food : IFood
    {
        public Food(int food)
        {
            Quantity = food;
        }

        public int Quantity { get; protected set; }
    }
}
