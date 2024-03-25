using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, string age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
    public string? Name { get; set; }
    public string Age { get; set; }
    public string Town { get; set; }

    public int CompareTo(Person? other)
    {
        int names = Name.CompareTo(other.Name);
        if (names == 0)
        {
            int ages = Age.CompareTo(other.Age);
            if (ages == 0)
            {
                int towns = Town.CompareTo(other.Town);

                return towns;
            }

            return ages;
        }

        return names;
    }
    }
}
