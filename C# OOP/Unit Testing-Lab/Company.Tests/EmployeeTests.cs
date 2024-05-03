using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Company.Tests
{
    public class EmployeeTests
    {
        private Guid guid = Guid.Parse("26a65572-35ef-4f87-9baf-92d1aa3de021");
        private string name = "Andrey";
        private int salary = 60000;
        [Test]
        public void When_CreatingANewEmployee_Id_ShouldNotBeNull()
        {
            Employee employee = new Employee();

            Assert.AreNotEqual(Guid.Empty, employee.Id);
        }
        [Test]
        public void When_CreatingANewEmployee_Data_ShouldBeSetCorrectly()
        {
            Employee employee = new Employee(guid, name, salary);
             
            Assert.AreEqual(guid, employee.Id);
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(salary, employee.Salary);
        }

        [Test]
        public void When_CreatingANewEmployee_Format_ShouldBeCorrect()
        {
            Employee employee = new Employee(guid, name, salary);
            Assert.AreEqual("26a65572-35ef-4f87-9baf-92d1aa3de021 - Andrey is paid - 60000", employee.ToString());
        }
    }

    
}
