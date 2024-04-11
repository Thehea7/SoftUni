using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_WildFarm.Models.Food.Interfaces;

namespace _04_WildFarm.Models.Animals.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }


        string AskForFood();

        void Feed(IFood food);
    }
}
