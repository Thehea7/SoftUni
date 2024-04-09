using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl.Models
{
    public abstract class Entity
    {
        protected Entity(string name, string id)
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
    }
}
