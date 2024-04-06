using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private readonly string name;
        private decimal money;

        public List<Product> BagOfProducts { get; private set; }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public string Name
        {
            get => name;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                BagOfProducts.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }

        }

        public override string ToString()
        {
            return BagOfProducts.Count > 0 ? $"{Name} - {string.Join(", ", BagOfProducts)}" : $"{Name} - Nothing bought";
        }
    }
}
