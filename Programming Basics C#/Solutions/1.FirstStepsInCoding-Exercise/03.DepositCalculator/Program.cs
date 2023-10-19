using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine()) * 0.01;

            //calc - сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double revenue = deposit + term * ((deposit * interest) / 12);
            //Print
            Console.WriteLine(revenue);
        }
    }
}
