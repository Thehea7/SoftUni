using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name = "No name";
        private int age = 1;

        public Person()
        {
            
        }

        public Person(int age)
        :this()
        {
            Age = age;
        }

        public Person(string name, int age)
        :this(age)
        {
            Name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

    }
}
