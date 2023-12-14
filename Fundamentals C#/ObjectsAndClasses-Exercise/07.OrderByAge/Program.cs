using System.Reflection.Emit;

namespace _07.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }

    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                int age = int.Parse(arguments[2]);
                string id = arguments[1];

                if (IdDoNotExist(people, id))
                {
                    Person newPerson = new Person(arguments[0], id, age);
                    people.Add(newPerson);
                }
                else
                {
                    UpdatePerson(people, arguments);
                }

            }
            List<Person> orderedList = people.OrderBy(p => p.Age).ToList();

            orderedList.ForEach(x => Console.WriteLine(x));
        }

        private static bool IdDoNotExist(List<Person> people, string id)
        {
            bool exist = true;
            if (people.Exists(x => x.Id == id))
            {
                exist = false;
            }

            return exist;
        }

        private static void UpdatePerson(List<Person> people, string[] argument)
        {
            string id = argument[1];
            int index = people.FindIndex(x => x.Id == id);
            people[index].Name = argument[0];
            people[index].Age = int.Parse(argument[2]);
        }
    }
}