using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public abstract class Soldier :ISoldier
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}
