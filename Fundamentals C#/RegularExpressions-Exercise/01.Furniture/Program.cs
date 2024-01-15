using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Furniture
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    internal class Program
    {
        static void Main()
        {

            Regex r = new Regex(
                @">>(?'name'([A-Za-z]+)|([A-Za-z]+ [A-Za-z]+))<<(?<price>(\d+)|(\d+\.\d+))!(?'quantity'\d+)");

            List<Furniture> furnitures = new List<Furniture>();

            string command;

            while ((command = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(command, r.ToString()))
                {

                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups["name"].Value;
                    furniture.Price = decimal.Parse(match.Groups["price"].Value);
                    furniture.Quantity = int.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(furniture);
                }
            }
            decimal totalCost = 0;

            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture);
                totalCost += furniture.Total();
            }

            Console.WriteLine($"Total money spend: {totalCost:f2}");


        }
    }
}