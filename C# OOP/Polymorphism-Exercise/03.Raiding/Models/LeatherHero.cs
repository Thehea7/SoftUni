using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Raiding.Models
{
    public abstract class LeatherHero : BaseHero
    {
        private const int PowerForleather = 80;

        public LeatherHero(string name) : base(name)
        {
            Power = PowerForleather;
        }

    }
}
