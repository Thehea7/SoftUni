namespace _05.ShoppingSpree
{
    class Product
    {
        public Product(string productName, double cost)
        {
            ProductName = productName;
            Cost = cost;
        }
        public string ProductName { get; set; }
        public double Cost { get; set; }
        public override string ToString()
        {
            return ProductName;
        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> BagOfProducts { get; set; } = new List<Product>();
        public override string ToString()
        {
            if (BagOfProducts.Count > 0)
            {
                return $"{Name} - {string.Join(", ", BagOfProducts)}";
            }
            return $"{Name} - Nothing bought";

        }
        public void AddBag(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.ProductName}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.ProductName}");
                Money -= product.Cost;
                BagOfProducts.Add(product);
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            string[] buyers = Console.ReadLine().Split(";");
            string[] goods = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < buyers.Length; i++)
            {
                string[] input = buyers[i].Split("=");
                Person person = new Person(input[0], double.Parse(input[1]));
                people.Add(person);
            }

            for (int i = 0; i < goods.Length; i++)
            {
                string[] input = goods[i].Split("=");
                Product product = new Product(input[0], double.Parse(input[1]));
                products.Add(product);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();
                string person = arguments[0];
                string good = arguments[1];
                Person buyer = people.Find(x => x.Name == person);
                Product product = products.Find(x => x.ProductName == good);

                buyer.AddBag(product);
            }

            people.ForEach(x => Console.WriteLine(x));
        }


    }
}