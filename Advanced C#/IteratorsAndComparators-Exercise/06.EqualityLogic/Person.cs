using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualityLogic 
{
    public class Person : IComparable<Person>
    {
        public Person(string name, string age)
        {
            Name = name;
            Age = age;
            
        }
    public string? Name { get; set; }
    public string Age { get; set; }
    

    public int CompareTo(Person? other)
    {
        int names = Name.CompareTo(other.Name);
        if (names == 0)
        {
            int ages = Age.CompareTo(other.Age);

            return ages;
        }

        return names;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        Person other = (Person)obj;
        if (other == null)
        {
            return false;
        }

        return Name == other.Name && Age == other.Age;
    }
    }
}
