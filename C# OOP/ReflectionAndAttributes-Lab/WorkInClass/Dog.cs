using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    [Documentation(MoreInfo = "Person's Best friend")] // for default constructor
   // [Documentation("value")] // for custom constructor
    public class Dog : Animal
    {
        
        private string name;
        public string description;
        private decimal price;

        
        public Dog(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public Dog(string name)
        {
            this.name = name;
        }
        public Dog()
        {
            
        }

        [Documentation]
        public override void ProduceSound()
        {
            Console.WriteLine(" Laf Laf");
        }


        public override string ToString()
        {
            return $"Name: {name}, Price: {price}";
        }
    }
}
