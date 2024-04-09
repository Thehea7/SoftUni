using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<ISoldier> privatesList) : base(id, firstName, lastName, salary)
        {
            PrivatesList = privatesList;
        }
        public List<ISoldier> PrivatesList { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates:");
            PrivatesList.ForEach(x => sb.AppendLine($"  {x.ToString()}"));

            return sb.ToString().TrimEnd();
        }
    }
}
