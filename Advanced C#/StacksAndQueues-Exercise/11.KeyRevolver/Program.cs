using System;

namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Queue<int> locks = new(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int reward = int.Parse(Console.ReadLine());
            int loadedBullets = barrelSize;
            

            while (bullets.Any() && locks.Any())
            {
                reward -= bulletPrice;
                loadedBullets -= 1;
                if (bullets.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (loadedBullets == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    loadedBullets = barrelSize;
                }
            }

            if (!locks.Any())
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${reward}");
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}