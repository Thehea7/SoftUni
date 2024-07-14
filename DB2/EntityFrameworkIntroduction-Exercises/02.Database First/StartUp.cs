using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main()
        {
            SoftUniContext context = new();


            //Console.WriteLine(GetEmployeesFullInformation(context));  //// 3.	Employees Full Information

            //Console.WriteLine(GetEmployeesWithSalaryOver50000(context)); // 4.	Employees with Salary Over 50 000

            //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context)); //05. Employees from Research and Development

            //Console.WriteLine(AddNewAddressToEmployee(context));  //06. Adding a New Address and Updating Employee

            // Console.WriteLine(GetEmployeesInPeriod(context)); //07. Employees and Projects

            // Console.WriteLine(GetAddressesByTown(context)); // 08. Addresses by Town

            //Console.WriteLine(GetEmployee147(context)); //09. Employee 147

            //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context)); //10. Departments with More Than 5 Employees

            // Console.WriteLine(GetLatestProjects(context));  //11. Find Latest 10 Projects

            // Console.WriteLine(IncreaseSalaries(context)); //12. Increase Salaries

            // Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context)); //13. Find Employees by First Name Starting With Sa

            // Console.WriteLine(DeleteProjectById(context)); //14. Delete Project by Id

            // Console.WriteLine(RemoveTown(context)); //15. Remove Town
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
        } // 3.	Employees Full Information

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
        } //4.	Employees with Salary Over 50 000


        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context) // 05. Employees from Research and Development
        {


            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    departmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName);
            // Console.WriteLine(employees.ToQueryString());

            StringBuilder sb = new();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.departmentName} - ${e.Salary:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address();
            address.AddressText = "Vitoshka 15";
            address.TownId = 4;

            Employee nakov = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            if (nakov != null)
            {
                nakov.Address = address;
            }

            context.SaveChanges();

            var employees = context.Employees
                .Select(e => new
                {
                    adresText = e.Address.AddressText,
                    id = e.AddressId
                })
                .OrderByDescending(e => e.id)
                .Take(10);

            StringBuilder sb = new();

            foreach (var e in employees)
            {
                sb.AppendLine(e.adresText);
            }

            return sb.ToString().Trim();
        } //06. Adding a New Address and Updating Employee

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Take(10)
                .Select(e => new
                {
                    EmployeeName = $"{e.FirstName} {e.LastName}",
                    ManagerName = $"{e.Manager.FirstName} {e.Manager.LastName}",
                    Projects = e.EmployeesProjects
                        .Where(ep =>
                            ep.Project.StartDate.Year >= 2001 &&
                            ep.Project.StartDate.Year <= 2003)
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name,
                            ep.Project.StartDate,
                            EndDate = ep.Project.EndDate.HasValue ?
                               ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") :
                               "not finished"
                        })

                }).ToList();

            StringBuilder sb = new();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.EmployeeName} - Manager: {e.ManagerName}");
                if (e.Projects.Any())
                {
                    foreach (var p in e.Projects)
                    {
                        sb.AppendLine($"--{p.ProjectName} - {p.StartDate:M/d/yyyy h:mm:ss tt} - {p.EndDate}");

                    }
                }
            }

            return sb.ToString().Trim();
        }  //07. Employees and Projects

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Select(a => new
                {
                    EmployeeCount = a.Employees.Count,
                    TownName = a.Town.Name,
                    a.AddressText
                }).OrderByDescending(a => a.EmployeeCount)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.AddressText)
                .Take(10);

            StringBuilder sb = new();

            foreach (var a in addresses)
            {
                sb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
            }

            return sb.ToString().Trim();
        } //08. Addresses by Town

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new();
            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    EmployeeName = $"{e.FirstName} {e.LastName} - {e.JobTitle}",
                    projects = e.EmployeesProjects
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name
                        })

                });

            foreach (var e in employee)
            {
                if (e != null)
                {
                    sb.AppendLine($"{e.EmployeeName}");

                    foreach (var project in e.projects.OrderBy(p => p.ProjectName))
                    {
                        sb.AppendLine(project.ProjectName);
                    }

                    return sb.ToString().Trim();
                }
            }



            return "not found";
        }  //09. Employee 147

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerName = $"{d.Manager.FirstName} {d.Manager.LastName}",
                    Employees = d.Employees
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            EmployeeName = $"{e.FirstName} {e.LastName}",
                            e.JobTitle
                        })
                });

            StringBuilder sb = new();
            foreach (var d in departments)
            {
                sb.AppendLine($"{d.DepartmentName} - {d.ManagerName}");
                foreach (var e in d.Employees.OrderBy(e => e.FirstName)
                             .ThenBy(e => e.LastName))
                {
                    sb.AppendLine($"{e.EmployeeName} - {e.JobTitle}");
                }
            }

            return sb.ToString().Trim();
        } //10. Departments with More Than 5 Employees

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                }).OrderByDescending(p => p.StartDate)
                .Take(10);

            StringBuilder sb = new();

            foreach (var p in projects.OrderBy(p => p.Name))
            {
                sb.AppendLine($"{p.Name}\n{p.Description}\n{p.StartDate:M/d/yyyy h:mm:ss tt}");
            }


            return sb.ToString().Trim();
        } //11. Find Latest 10 Projects

        public static string IncreaseSalaries(SoftUniContext context)  //12. Increase Salaries
        {
            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering"
                            || e.Department.Name == "Tool Design"
                            || e.Department.Name == "Marketing"
                            || e.Department.Name == "Information Services")
                .ToList();
            foreach (var employee in employees)
            {
                employee.Salary *= 1.12m;
            }

            context.SaveChanges();

            var result = context.Employees
                .Where(e => e.Department.Name == "Engineering"
                            || e.Department.Name == "Tool Design"
                            || e.Department.Name == "Marketing"
                            || e.Department.Name == "Information Services")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                }).OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName);

            StringBuilder sb = new();

            foreach (var e in result)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new();
            var employees = context.Employees
                .Where(e => e.FirstName.ToLower().StartsWith("sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    e.JobTitle
                }).OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName);

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return sb.ToString().Trim();
        } //13. Find Employees by First Name Starting With Sa

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new();

            var project = context.Projects.Find(2);

            var epToBeRemoved = context.EmployeesProjects.Where(ep => ep.ProjectId == 2);
            foreach (var employeeProject in epToBeRemoved)
            {
                context.EmployeesProjects.Remove(employeeProject);
            }

            context.Projects.Remove(project);
            context.SaveChanges();

            var projects = context.Projects.Take(10);

            foreach (var p in projects)
            {
                sb.AppendLine($"{p.Name}");
            }

            return sb.ToString().Trim();
        } //14. Delete Project by Id

        public static string RemoveTown(SoftUniContext context)
        {
            StringBuilder sb = new();

            var town = context.Towns.FirstOrDefault(t => t.Name == "Seattle");
            var employes = context.Employees.Where(e => e.Address.Town.Name == "Seattle");
            foreach (var e in employes)
            {
                e.AddressId = null;
            }

            var addresses = context.Addresses.Where(a => a.Town == town);
            int count = default;
            foreach (var address in addresses)
            {
                context.Addresses.Remove(address);
                count++;
            }

            context.Towns.Remove(town);
            context.SaveChanges();

            return $"{count} addresses in Seattle were deleted";
        }  //15. Remove Town
    }
}
