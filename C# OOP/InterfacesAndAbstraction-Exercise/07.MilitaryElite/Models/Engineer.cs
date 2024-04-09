using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Engineer : SpecialSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }
        public List<Repair> Repairs { get; init; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Repairs:");
            Repairs.ForEach(x => sb.AppendLine($"  {x.ToString()}"));

            return sb.ToString().TrimEnd();
        }

        
    }
}
