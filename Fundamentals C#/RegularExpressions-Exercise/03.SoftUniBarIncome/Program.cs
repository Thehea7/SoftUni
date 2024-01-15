using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main()
        {
            Regex pattern =
                new Regex(
                    @"%(?<user>[A-Z][a-z]+)%.*<(?'product'\w+)>.*\|(?'quantity'\d+)\|\D*(?'price'(\d+.\d+|\d+))\$");
            double income = 0;
            string command;
            while ((command = Console.ReadLine()) != "end of shift")
            {
               
                if (pattern.IsMatch(command))
                {
                    Match match = pattern.Match(command);
                    double totalPrice = int.Parse(match.Groups["quantity"].ToString()) * double.Parse(match.Groups["price"].ToString());

                    Console.WriteLine($"{match.Groups["user"]}: {match.Groups["product"]} - {totalPrice:f2}");
                    income += totalPrice;
                }

            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}