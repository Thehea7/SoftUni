using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main()
        {
            SoftUniContext context = new ();


            //Console.WriteLine(GetEmployeesFullInformation(context));  //// 3.	Employees Full Information

            Console.WriteLine(GetEmployeesWithSalaryOver50000(context)); // 4.	Employees with Salary Over 50 000

        }

       
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            ////Option 1
            //return string.Join(Environment.NewLine, context.Employees
            //    .Select(e => $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}")
            //    .ToList());

            //Option 2
            var employees = context.Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.EmployeeId)
                .ToList();

            StringBuilder sb = new();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }
            return sb.ToString().Trim();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var richEmployees = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName);

            StringBuilder sb = new();

            foreach (var e in richEmployees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return sb.ToString().Trim();
        }
    }
}
