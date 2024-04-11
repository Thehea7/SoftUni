using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Raiding.Models
{
    public abstract class PlateHero : BaseHero
    {
        private const int PowerForPlate = 100;
        protected PlateHero(string name) : base(name)
        {
            Power = PowerForPlate;
        }
    }
}
