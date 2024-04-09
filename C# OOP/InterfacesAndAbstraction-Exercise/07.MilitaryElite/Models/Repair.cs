using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07.MilitaryElite.Models
{
    public class Repair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; init; }
        public int HoursWorked { get; init; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
