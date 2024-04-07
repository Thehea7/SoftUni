using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public  class Tesla : IElectricCar
    {

        public Tesla(string model, string color, int bateries)
        {
            Name = model;
            Color = color;
            Batteries = bateries;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Batteries { get; set; }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Tesla {Name} with {Batteries} Batteries\n{Start()}\n{Stop()}";
        }
    }
}
