using DBFirstDemo.Data;
using DBFirstDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirstDemo
{
    internal class Program
    {
        static async Task Main()
        {
           using SoftUniDbContext context = new SoftUniDbContext();

            //Employee emp = new Employee()
            //{
            //    FirstName = "Petar",
            //    LastName = "Petrov",
            //    DepartmentId = 1,
            //    HireDate = DateTime.Now,
            //    JobTitle = "Dev",
            //    Salary = 12000
            //};

            //await context.Employees.AddAsync(emp);
            var emp1 = await context.Employees
                .Where(e => e.LastName == "Petrov")
                .FirstOrDefaultAsync();

            //context.Employees.Remove(emp1);
            //emp1.Salary = 0;

            // await context.SaveChangesAsync();

            var employees = await context.Employees
               .Select(e => new
               {
                   e.FirstName,
                   e.LastName,
                   e.JobTitle,
                   e.Salary
               })
               .ToListAsync();

           foreach (var employee in employees)
           {
               Console.WriteLine($"{employee.FirstName} {employee.LastName} ({employee.JobTitle}) - {employee.Salary}");
           }

           Console.WriteLine(nameof(SoftUniDbContext));
           Console.WriteLine(typeof(SoftUniDbContext));
        }
    }
}