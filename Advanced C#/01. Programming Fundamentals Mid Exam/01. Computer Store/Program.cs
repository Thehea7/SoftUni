namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main()
        {
            string command;
            decimal sum = 0;
            while ((command = Console.ReadLine()) != "special" && command != "regular")
            {
                decimal CurrentPrice = decimal.Parse(command);
                if (CurrentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                sum += CurrentPrice;
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            decimal price = sum * 1.2m;
            decimal totalPrice = default;
            if (command == "special")
            {
                 totalPrice = price * 0.9m;
            }
            else
            {
                totalPrice = price;
            }
            

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {price - sum:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}