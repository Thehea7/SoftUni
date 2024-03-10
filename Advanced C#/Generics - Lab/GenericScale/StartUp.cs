namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> equal = new EqualityScale<string>("left", "left");
            Console.WriteLine(equal.AreEqual());

        }
    }
}