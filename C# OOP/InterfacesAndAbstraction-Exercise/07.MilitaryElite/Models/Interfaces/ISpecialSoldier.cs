using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite.Models.Interfaces
{
    public interface ISpecialSoldier : IPrivate
    {
        public string Corps { get; init; }
    }
}
