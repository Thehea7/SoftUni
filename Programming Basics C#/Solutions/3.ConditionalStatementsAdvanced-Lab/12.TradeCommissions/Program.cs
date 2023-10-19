using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            //calc
            double bonus = 0;
            

            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500) { bonus = 0.05; }
                    else if (sales > 500 && sales <= 1000) { bonus = 0.07; }
                    else if (sales > 1000 && sales <= 10000) { bonus = 0.08; }
                    else if (sales > 10000) { bonus = 0.12; }

                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500) { bonus = 0.045; }
                    else if (sales > 500 && sales <= 1000) { bonus = 0.075; }
                    else if (sales > 1000 && sales <= 10000) { bonus = 0.1; }
                    else if (sales > 10000) { bonus = 0.13; }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500) { bonus = 0.055; }
                    else if (sales > 500 && sales <= 1000) { bonus = 0.08; }
                    else if (sales > 1000 && sales <= 10000) { bonus = 0.12; }
                    else if (sales > 10000) { bonus = 0.145; }
                    break;
               

            }
            double commission = bonus * sales;
            if (sales >= 0 && (city == "Sofia" || city == "Plovdiv" || city == "Varna"))
                Console.WriteLine($"{commission:f2}");
            else Console.WriteLine("error");

        }

    }
}
