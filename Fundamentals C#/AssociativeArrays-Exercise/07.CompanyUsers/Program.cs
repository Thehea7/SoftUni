namespace _07.CompanyUsers
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
            Employees = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Employees { get; set; }

        public override string ToString()
        {
            return $"{Name}\n-- {string.Join("\n-- ", Employees)}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Company> companiesMap = new Dictionary<string, Company>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" -> ");
                string name = arguments[0];
                string employee = arguments[1];

                if (!companiesMap.ContainsKey(name))
                {
                    companiesMap.Add(name, new Company(name));
                }

                if (!companiesMap[name].Employees.Contains(employee))
                {
                    companiesMap[name].Employees.Add(employee);
                }
            }

            foreach (var company in companiesMap)
            {
                Console.WriteLine(company.Value);
            }


        }
    }
}