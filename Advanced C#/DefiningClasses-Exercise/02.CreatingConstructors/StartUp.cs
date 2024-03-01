namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new();

            Console.WriteLine($"{person.Name} : {person.Age}");
        }
    }
}