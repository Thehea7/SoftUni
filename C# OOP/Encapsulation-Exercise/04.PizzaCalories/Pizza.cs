using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private readonly string name;
        private List<Topping> toppings;


        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }


        public Dough Dough { get; set; }
        public decimal Calories
        {
            get
            {
                decimal result = Dough.Calories;
                toppings.ForEach(x => result += x.Calories);
                return result;
            }
        }
        public int ToppingsCount => toppings.Count;// I don't need that, made because of condition
        public void AddTopping(Topping topping)
        {
            if (ToppingsCount < 10)
                toppings.Add(topping);
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
        public string Name
        {
            get => name;
            init
            {
                if (string.IsNullOrWhiteSpace(value)
                    || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }


        }

    }
}
