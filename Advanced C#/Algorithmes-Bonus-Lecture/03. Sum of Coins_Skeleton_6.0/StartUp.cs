using System.Linq;

namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            List<int> coins = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            coins.Sort();
            coins.Reverse();

            int targetSum = int.Parse(Console.ReadLine());




            result = ChooseCoins(coins, targetSum);

            int numberOfCoins = 0;
            foreach (var (coin, count) in result)
            {
                numberOfCoins += count;
            }

            Console.WriteLine($"Number of coins to take: {numberOfCoins}");
            foreach (var (coin, count) in result)
            {
                Console.WriteLine($"{count} coin(s) with value {coin}");
            }




        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            int currentSum = 0;
            Dictionary<int, int> result = new();
            for (int i = 0; i < coins.Count; i++)
            {
                while (currentSum + coins[i] <= targetSum)
                {
                    if (result.ContainsKey(coins[i]) == false)
                    {
                        result.Add(coins[i], default);
                    }
                    result[coins[i]]++;
                    currentSum += coins[i];
                }
            }

            if (currentSum != targetSum)
            {
                throw new InvalidOperationException();
            }

            return result;
        }
    }
}