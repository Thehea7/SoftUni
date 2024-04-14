using P03.Detail_Printer.Models.Interfaces;

namespace P03.Detail_Printer.Models
{
    public class Employee : IEmploye
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
