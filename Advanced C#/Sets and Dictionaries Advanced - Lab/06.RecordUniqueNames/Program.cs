﻿namespace _06.RecordUniqueNames
{
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < entries; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}