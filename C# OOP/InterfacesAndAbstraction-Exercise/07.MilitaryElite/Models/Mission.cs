using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite.Models
{
    public class Mission
    {
        public Mission(string name, string status)
        {
            Name = name;
            Status = status;
        }

        public string Name { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Code Name: {Name} State: {Status}";
        }
    }
}
