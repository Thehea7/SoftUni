using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BirthdayCelebrations.Models.Interfaces;

namespace _05.BirthdayCelebrations
{
    public  class Entity : IBuyer
    {
        public Entity(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string  Name { get; init; }
        public string Id { get; init; }

        public override string ToString()
        {
            return Id;
        }

        public int Food { get;}
        public void BuyFood()
        {
            throw new NotImplementedException();
        }
    }
}
