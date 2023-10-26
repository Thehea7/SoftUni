using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
           bool isEqual = true;
            int i;
            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i] || array1.Length != array2.Length)
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    sum += array1[i];
                }
            }

            if ( !isEqual ) 
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}