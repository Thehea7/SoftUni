namespace _01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());

            List<Employee> stuff = new List<Employee>();

            List<string> departmentsList = new List<string>();


            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split();
                double salary = double.Parse(input[1]);

                Employee newEmployee = new Employee(input[0], salary, input[2]);
                stuff.Add(newEmployee);

                if (DepartmentDoNotExist(departmentsList, input[2]))
                {
                    departmentsList.Add(input[2]);
                }
            }

            string maxDepartment = FindMaxDepartment(departmentsList, stuff);

            List<Employee> output = stuff.Where(x => x.Department == maxDepartment).ToList();

            output = output.OrderByDescending(x => x.Salary).ToList();

            //Print Output
            Console.WriteLine($"Highest Average Salary: {maxDepartment}");
            output.ForEach(x => Console.WriteLine(x));
        }

        private static bool DepartmentDoNotExist(List<string> departments, string department)
        {
            bool exists = true;
            if (departments.Exists(x => x == department))
            {
                exists = false;
            }

            return exists;
        }

        private static string FindMaxDepartment(List<string> departmentsList, List<Employee> stuff)
        {
            string maxDepartment = "";
            double maxAverage = default;

            for (int i = 0; i < departmentsList.Count; i++)
            {
                List<Employee> newList = stuff.Where(x => x.Department == departmentsList[i]).ToList();
                double totalSalary = 0;
                foreach (Employee newEmployee in newList)
                {
                    totalSalary += newEmployee.Salary;
                }
                double average = totalSalary / newList.Count;
                if (average > maxAverage)
                {
                    maxAverage = average;
                    maxDepartment = departmentsList[i];
                }
            }

            return maxDepartment;
        }
    }
}