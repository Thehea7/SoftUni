using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                family.AddMemeber(new Person(input[0], int.Parse(input[1])));
            }

            List<Person> filteredFamily = family.People
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            filteredFamily.ForEach(Console.WriteLine);
        }
    }
}