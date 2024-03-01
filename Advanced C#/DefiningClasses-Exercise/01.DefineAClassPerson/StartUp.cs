namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();
            person.Age = 20;
            person.Name = "Peter";

            Console.WriteLine(person.Name);
        }
    }
}