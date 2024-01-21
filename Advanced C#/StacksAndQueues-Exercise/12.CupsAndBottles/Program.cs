using System;

namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = default;
            while (cups.Any() && bottles.Any())
            {
                int bottle = bottles.Pop();
                int cup = cups.Dequeue();

                if (bottle < cup)
                {
                    cup -= bottle;
                    cups = new Queue<int>(cups.Reverse());
                    cups.Enqueue(cup);
                    cups = new Queue<int>(cups.Reverse());


                }
                else if(bottle > cup)
                {
                    wastedWater += bottle - cup;
                }
            }
            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}