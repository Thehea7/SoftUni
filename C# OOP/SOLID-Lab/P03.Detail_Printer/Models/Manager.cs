using P03.Detail_Printer.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace P03.Detail_Printer.Models
{
    public class Manager : IEmploye
    {


        public Manager(string name, ICollection<string> documents)
        {
            Name = name;
            Documents = new List<string>(documents);
        }
        public string Name { get; set; }
        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            return Name + $"{Environment.NewLine}{string.Join(Environment.NewLine, Documents)}";

        }
    }
}
