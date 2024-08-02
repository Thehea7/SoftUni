using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        public int Height { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} years old and is {Height} cm high and weights {Weight} kg";
        }


    }
}
