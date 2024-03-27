using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SetCover
{
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] universe = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfSets = int.Parse(Console.ReadLine());

            int[][] sets = new int[numberOfSets][];
            for (int row = 0; row < numberOfSets; row++)
            {
                int[] rowsValue = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sets[row] = new int[rowsValue.Length];

                for (int col = 0; col < sets[row].Length; col++)
                {
                    sets[row][col] = rowsValue[col];
                }
            }

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());

            Console.WriteLine($"Sets to take ({selectedSets.Count}):");
            foreach (var set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> selectedSets = new();

            while (universe.Count>0)
            {
                int[] longestSet = sets
                    .OrderByDescending(s => s.Count(x => universe.Contains(x)))
                    .FirstOrDefault();

                selectedSets.Add(longestSet);
                sets.Remove(longestSet);
                for (int i = 0; i < longestSet.Length; i++)
                {
                    if (universe.Contains(longestSet[i]))
                    {
                        universe.Remove(longestSet[i]);
                    }
                }

            }

            
            return selectedSets;
        }
    }
}
