using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private readonly string flourType;
        private readonly string bakingTechnique;
        private readonly decimal weight;

        public Dough(string flourType, string backingTechnique, decimal weight)
        {
            FlourType = flourType;
            BakingTechnique = backingTechnique;
            Weight = weight;

        }

        public decimal Calories
        {
            get
            {
                decimal multiplier1 = default;
                decimal multiplier2 = default;
                multiplier1 = FlourType switch
                {
                    "white" => 1.5m,
                    "wholegrain" => 1m,
                    _ => multiplier1
                };

                multiplier2 = BakingTechnique switch
                {
                    "crispy" => 0.9m,
                    "chewy" => 1.1m,
                    "homemade" => 1,
                    _ => multiplier2
                };

                return multiplier1 * multiplier2 * 2 * Weight;
                
            }
        }
        private string BakingTechnique
        {
            get => bakingTechnique;
            init
            {
                if (value.ToLower() != TechnicsOfBaking.crispy.ToString() && 
                    value.ToLower() != TechnicsOfBaking.chewy.ToString() &&
                    value.ToLower() != TechnicsOfBaking.homemade.ToString())
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value.ToLower();
            }
        }
        private string FlourType
        {
            get => flourType;
            init
            {
                if (value.ToLower() != TypesOfFlour.white.ToString() &&
                    value.ToLower() != TypesOfFlour.wholegrain.ToString())
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value.ToLower();
            }

        }
        private decimal Weight
        {
            get => weight;
            init
            {
                if (value is < 1 or > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

      

        private enum TypesOfFlour
        {
            white,
            wholegrain

        }
        private enum TechnicsOfBaking
        {
        	crispy,
            chewy,
            homemade
        }

    }
}
