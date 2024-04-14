using P03.Detail_Printer.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace P03.Detail_Printer.Models
{
    public class DetailsPrinter
    {
        private IList<IEmploye> employees;

        public DetailsPrinter(IList<IEmploye> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
