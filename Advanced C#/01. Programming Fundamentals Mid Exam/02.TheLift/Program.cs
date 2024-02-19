namespace _02.TheLift
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < wagons.Length; i++)
            {

                while (wagons[i] < 4)
                {
                    people--;
                    wagons[i]++;
                    if (people == 0)
                    {
                        if (wagons[i] == 4 && i == wagons.Length -1)
                        {
                            Console.WriteLine(string.Join(" ", wagons));
                            return;
                        }
                        PrintResult(wagons);
                        return;
                    }
                    
                }
            }
            PrintResult2(people, wagons);
        }

        private static void PrintResult2(int people, int[] wagons)
        {
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void PrintResult(int[] wagons)
        {
            Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}