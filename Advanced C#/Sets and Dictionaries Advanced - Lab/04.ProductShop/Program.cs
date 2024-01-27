using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            
            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] arguments = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if(!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}