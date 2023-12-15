namespace _02.OldestFamilyMember
{
    class Person
    {
        public Person()
        {
            
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    class Family
    {
        public List<Person> People { get; set; } = new List<Person>();

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = new Person();
            List<Person> orderedByAge = People.OrderByDescending(x => x.Age).ToList();
            person = orderedByAge[0];

            return person;
        }
    }

    internal class Program
    {
        static void Main()
        {
            int members = int.Parse(Console.ReadLine());
            Family family = new Family(); 
            for (int i = 0; i < members; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine(oldestPerson);
        }
    }
}
