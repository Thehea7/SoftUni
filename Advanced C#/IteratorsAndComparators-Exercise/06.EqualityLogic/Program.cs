using _06.EqualityLogic;

SortedSet<Person>  sortedSet  = new SortedSet<Person>();
HashSet<Person> hashSet = new HashSet<Person>();

int entries = int.Parse(Console.ReadLine());

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split();
    Person newPerson = new Person(input[0], input[1]);
    sortedSet.Add(newPerson);
    hashSet.Add(newPerson);
}

Console.WriteLine(sortedSet.Count);
Console.WriteLine(hashSet.Count);