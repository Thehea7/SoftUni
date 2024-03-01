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

            Console.WriteLine(family.GetOldestMember());
        }
    }
}