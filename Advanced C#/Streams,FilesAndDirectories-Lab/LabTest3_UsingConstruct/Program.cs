namespace labTest3_UsingConstruction
{
    class Reader : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose is Called !");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            using (reader)
            {
                Console.WriteLine("Before Dispose");
            }
            Console.WriteLine("After Dispose");
        }

    }
    
}