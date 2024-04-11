using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Raiding.Models.Interfaces;

namespace _03_Raiding.Models
{
    public abstract class BaseHero :IBaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public int Power { get; protected set; }
        public string Name { get; init; }
        public abstract string CastAbility();


    }
}
