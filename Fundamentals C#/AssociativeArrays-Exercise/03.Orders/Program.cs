namespace _03.Orders
{
    class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void UpdatePriceAndQuantity(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Product> productsMap = new Dictionary<string, Product>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();
                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);
                Product product = new Product(name);
                if (!productsMap.ContainsKey(name))
                {
                    productsMap.Add(name, product);
                }
                productsMap[name].UpdatePriceAndQuantity(price, quantity);
            }

            foreach (var product in productsMap)
            {
                Console.WriteLine(product.Value);
            }

            

        }
    }
}