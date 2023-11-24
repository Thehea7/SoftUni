namespace _4.ListOfProducts
{
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int i = 1; i <= entries; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);    
            }
            products.Sort();
            for (int i = 1; i <= entries; i++)
            {
                Console.WriteLine($"{i}.{products[i-1]}");
            }
        }
    }
}