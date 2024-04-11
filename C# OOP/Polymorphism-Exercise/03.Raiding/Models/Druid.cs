using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Raiding.Models.Interfaces;

namespace _03_Raiding.Models
{
    public class Druid : LeatherHero
    {
        public Druid(string name) : base(name)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }

        
    }
}
