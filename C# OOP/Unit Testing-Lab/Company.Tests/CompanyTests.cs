using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Tests
{
    internal class CompanyTests
    {
        private Department department;
        private Employee employee1;
        private Employee employee2;
        private Employee employee3;
        private Company company;

        [SetUp]
        public void SetUp()
        {
            employee1 = new Employee(Guid.NewGuid(), "employee1", 1000);
            employee2 = new Employee(Guid.NewGuid(), "employee2", 2000);
            employee3 = new Employee(Guid.NewGuid(), "employee3", 3000);

            department = new Department(employee1, employee2, employee3);
            company.Departments.Add(department);
        }

        [Test]
        public void When_RaiseSalary_Company_ShouldCall_Department_RaiseSalary()
        {
            //TODO
        }
    }
}
