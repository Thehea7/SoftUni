using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite.Models.Interfaces
{
    public interface ICommando : ISpecialSoldier
    {
        List<Mission> Missions { get; }
    }
}
