using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const decimal BaseModifier = 2;
		private readonly string  type;
        private readonly decimal weight;

        public Topping(string type, decimal grams)
        {
            Type = type;
            Weight = grams;
        }

        public decimal Calories
        {
            get
            {
                decimal specialModifier = this.Type.ToLower() switch
                {
                    "meat" => 1.2m,
                    "veggies" => 0.8m,
                    "cheese" => 1.1m,
                    "sauce" => 0.9m,
                    _ => 1
                };

                return Weight * specialModifier * BaseModifier;
            }
        }
        public decimal Weight
        {
            private get => weight;
            init
            {
                if (value is < 1 or > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public string  Type
		{
			private get => type;
            init
            {
                if (value.ToLower() is not ("meat" or "veggies" or "cheese" or "sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
		}

	}
}
