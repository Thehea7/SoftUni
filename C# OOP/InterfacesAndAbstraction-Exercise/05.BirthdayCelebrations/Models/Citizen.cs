

using _05.BirthdayCelebrations.Models.Interfaces;
using System.Xml.Linq;

namespace _05.BirthdayCelebrations
{
    public class Citizen : Entity, IBorn, IAge, IBuyer
    {
        public Citizen(string name, string id) : base(name, id)
        {
            
            
        }
        
        public Citizen(string name, string id,int age, string birthday) : base(name, id)
        {
            Birthday = birthday;
            Age = age;
        }
        public int Age { get; init; }
        public string Birthday { get; init; }
        public int Food { get;private set; }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}
