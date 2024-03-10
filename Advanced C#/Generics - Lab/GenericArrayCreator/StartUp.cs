namespace GenericArrayCreator
{
    
    public class StartUp
    {
        static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");

            Console.WriteLine(string.Join(", ", strings));
        }
    }
}