namespace _05.Orders
{
    internal class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            PrintTotalPrice(product, quantity);
        }

        private static void PrintTotalPrice(string? product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "water":
                    price = 1;
                    break;
                case "coffee":
                    price = 1.5;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }

            Console.WriteLine($"{quantity * price:f2}");
        }
    }
}