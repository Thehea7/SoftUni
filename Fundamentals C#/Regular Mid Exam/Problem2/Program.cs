namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            List<string> coffeeList = ReadList();
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                List<string> commandsArray = ReadList();
                string command = commandsArray[0];
                switch (command)
                {
                    case "Include":
                        coffeeList= Include(coffeeList, commandsArray);
                        break;
                    case "Remove":
                       coffeeList = Remove(coffeeList, commandsArray);
                        break;
                    case "Prefer":
                        coffeeList = Prefer(coffeeList, commandsArray);
                        break;
                    case "Reverse":
                        coffeeList.Reverse();
                        break;
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeList));
        }

        private static List<string> ReadList()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        private static bool BothIndexesAreValid(int index1, int index2, List<string> coffeeList)
        {
            if (index1 < 0
                || index2 < 0
                || index1 >= coffeeList.Count
                || index2 >= coffeeList.Count)
            {
                return false;
            }

            return true;
        }
        private static List<string> Include(List<string> coffeeList, List<string> commandsArray)
        {
            string newCoffee = commandsArray[1];
            coffeeList.Add(newCoffee);
            return coffeeList;
        }
        private static List<string> Remove(List<string> coffeeList, List<string> commandsArray)
        {
            string pointer = commandsArray[1];
            int numberOfCoffees = int.Parse(commandsArray[2]);
            if (coffeeList.Count >= numberOfCoffees)
            {
                if (pointer == "first")
                {
                    coffeeList.RemoveRange(0, numberOfCoffees);
                }

                if (pointer == "last")
                {
                    coffeeList.RemoveRange(coffeeList.Count - numberOfCoffees, numberOfCoffees);
                }
            }

            return coffeeList;
        }
        private static List<string> Prefer(List<string> coffeeList, List<string> commandsArray)
        {
            int index1 = int.Parse(commandsArray[1]);
            int index2 = int.Parse(commandsArray[2]);

            if (BothIndexesAreValid(index1, index2, coffeeList))
            {
                string coffe1 = coffeeList[index1];
                coffeeList[index1] = coffeeList[index2];
                coffeeList[index2] = coffe1;
            }

            return coffeeList;
        }
    }
}