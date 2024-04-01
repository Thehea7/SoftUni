using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Student : Person
    {
        public string School { get; set; }

        public Student(string name) 
            : base(name)
        {

        }
    }
}
