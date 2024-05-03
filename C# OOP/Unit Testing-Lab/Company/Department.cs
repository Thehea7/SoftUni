using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Department
    {

        public Department(params Employee[] employees )
        {
            Employees = employees.ToList();
        }
        public List<Employee> Employees { get; set; }

        public string Name { get; set; }

        public void RaiseSalary(int percentage)
        {
            foreach (var employee in Employees)
            {
                employee.Salary += employee.Salary * percentage/100;
            }
        }

        public void Firepeopele(Guid id)
        {
           var employee = Employees.FirstOrDefault(e => e.Id == id);
           if (employee != null)
           {
               employee.Salary = 0;
               Employees.Remove(employee);
           }
           else
           {
               throw new ArgumentException(" No Such Employee found");
           }
        }
    }
}
