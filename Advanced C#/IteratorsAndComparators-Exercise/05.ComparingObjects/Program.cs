using _05.ComparingObjects;

List<Person> people  = new List<Person>();

string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    people.Add(new Person(arguments[0], arguments[1], arguments[2]));
}

int matches = 0;
int notMatches = 0;
int totalPeople = 0;
Person comparer = people[int.Parse(Console.ReadLine()) -1];

foreach (Person person in people)
{
    totalPeople++;
    if (person.CompareTo(comparer) == 0)
    {
        matches++;
    }
    else
    {
        notMatches++;
    }
}

if (matches <2)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{matches} {notMatches} {totalPeople}");
}


