using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BirthdayCelebrations.Models.Interfaces;

namespace _05.BirthdayCelebrations.Models
{
    public class Pet :Entity, IBorn
    {
        public string Birthday { get; init; }
        public Pet(string name, string birthday) : base(name, birthday)
        {
            Birthday = birthday;
        }
    }
}
