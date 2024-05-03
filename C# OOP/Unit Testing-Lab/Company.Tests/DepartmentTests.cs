using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Company.Tests
{
    public class DepartmentTests
    {
        private Department department;
        private Employee employee1;
        private Employee employee2;
        private Employee employee3;

        [SetUp]
        public void SetUp()
        {
             employee1 = new Employee(Guid.NewGuid(), "employee1", 1000);
             employee2 = new Employee(Guid.NewGuid(), "employee2", 2000);
             employee3 = new Employee(Guid.NewGuid(), "employee3", 3000);

            department = new Department(employee1, employee2, employee3);
        }

        [Test]
        public void When_RaiseSalary_Employees_Should_Have_CorrectData()
        {
            
            department.RaiseSalary(20);

            AreEqual(1200, employee1.Salary);
            AreEqual(2400, employee2.Salary);
            AreEqual(3600, employee3.Salary);
        }

        [Test]
        public void When_FiringPeople_EmployeeShouldBeRemoved_AndSalary_ShouldBe0()
        {
            
            Employee employee = department.Employees[1];
            department.Firepeopele(employee.Id);

            AreEqual(2,department.Employees.Count);
            AreEqual(0, employee.Salary);
            IsFalse(department.Employees.Contains(employee2));
        }
        [Test]
        public void When_FiringPeople_AndPersonIs_NotFound_Exception_ShouldBeThrown()
        {

            Employee employee = department.Employees[1];
            

            Assert.Throws<ArgumentException>(() =>
            {
                department.Firepeopele(Guid.NewGuid());
            });

        }

    }
}
