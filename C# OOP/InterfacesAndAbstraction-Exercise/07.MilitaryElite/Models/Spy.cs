using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public int CodeNumber { get; init; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Number: {CodeNumber}");

            return sb.ToString().TrimEnd();
        }

        
    }
}
