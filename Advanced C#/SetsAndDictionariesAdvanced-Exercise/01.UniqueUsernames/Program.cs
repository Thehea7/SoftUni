﻿namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            HashSet<string>names = new HashSet<string>();
            for (int i = 0; i < entries; i++)
            {
                string name = Console.ReadLine();
                names. Add(name);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}