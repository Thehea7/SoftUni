using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BirthdayCelebrations.Models.Interfaces;

namespace _05.BirthdayCelebrations.Models
{
    public class Rebel :Entity, IAge, IBuyer
    {
        public Rebel(string name, string id) : base(name, id)
        {
        }

        public int Age { get; init; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            Food += 5;
        }
    }
}
