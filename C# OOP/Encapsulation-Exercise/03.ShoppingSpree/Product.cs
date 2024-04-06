using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Product
    {
		private readonly string name;
		private readonly decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

		public decimal Cost
		{
			get => cost;

           init 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
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

        public override string ToString()
        {
            return Name;
        }
    }
}
