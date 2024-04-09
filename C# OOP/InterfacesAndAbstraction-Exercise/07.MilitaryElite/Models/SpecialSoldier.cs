using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialSoldier : Private, ISpecialSoldier
    {
        protected SpecialSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps { get; init; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");

            return sb.ToString().TrimEnd();
        }
    }
}
