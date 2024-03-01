using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = System.Math;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; } = new List<Person>();

        public void AddMemeber(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            return People.Find(x => x.Age == People.Max(y => y.Age));
        }
    }
}
