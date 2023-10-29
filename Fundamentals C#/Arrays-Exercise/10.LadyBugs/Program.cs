namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] intitalSetUp = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();
            for (int i = 0; i < intitalSetUp.Length; i++)
            {
                if (intitalSetUp[i] >= 0 && intitalSetUp[i] < field.Length)
                    field[intitalSetUp[i]] = 1;
            }

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                string destination = command[1];
                int index = int.Parse(command[0]);
                int flyingLenght = int.Parse(command[2]);

                if (destination == "right" && index >= 0 && index < field.Length && field[index] == 1)
                {
                    field[index] = 0;
                    int landingIndex = index + flyingLenght;

                    while (landingIndex >= 0 && landingIndex < field.Length && field[landingIndex] == 1)
                    {
                        index = landingIndex;
                        landingIndex = index + flyingLenght;
                    }
                    if (landingIndex >= 0 && landingIndex < field.Length)
                    {
                        field[landingIndex] = 1;
                    }
                }
                else if (destination == "left" && index >= 0 && index < field.Length && field[index] == 1)
                {
                    field[index] = 0;
                    int landingIndex = index - flyingLenght;

                    while (landingIndex >= 0 && landingIndex < field.Length && field[landingIndex] == 1)
                    {
                        index = landingIndex;
                        landingIndex = index - flyingLenght;
                    }
                    if (landingIndex >= 0 && landingIndex < field.Length)
                    {
                        field[landingIndex] = 1;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));

        }

    }
}


//namespace _10.LadyBugs
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] field = new int[int.Parse(Console.ReadLine())];
//            int[] intitalSetUp = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToArray();
//            for (int i = 0; i < intitalSetUp.Length; i++)
//            {
//                if (intitalSetUp[i] >= 0 && intitalSetUp[i] < field.Length)
//                    field[intitalSetUp[i]] = 1;
//            }

//            string input = Console.ReadLine();
//            while (input != "end")
//            {
//                string[] command = input.Split();
//                int index = int.Parse(command[0]);
//                int flyLength = int.Parse(command[2]);
//                if (index >= 0 && index < field.Length && field[index] == 1)
//                {
//                    int landIndex = 0;
//                    field[index] = 0;
//                    if (command[1] == "right")
//                    {
//                        landIndex = index + flyLength;
//                    }
//                    else if (command[1] == "left")
//                    {
//                        landIndex = index - flyLength;
//                    }
//                    if (landIndex >= 0 && landIndex < field.Length)
//                    {
//                        while (field[landIndex] == 1 && landIndex >= 0 && landIndex < field.Length)
//                        {
//                            if (command[1] == "right")
//                            {
//                                landIndex = index + flyLength;
//                                if (landIndex < 0 || landIndex >= field.Length) break;
//                                index = landIndex;
//                            }
//                            else if (command[1] == "left")
//                            {
//                                landIndex = index - flyLength;
//                                if (landIndex < 0 || landIndex >= field.Length) break;
//                                index = landIndex;
//                            }
//                        }
//                        if (landIndex >= 0 && landIndex < field.Length)
//                            field[landIndex] = 1;
//                    }

//                }
//                input = Console.ReadLine();
//            }
//            Console.WriteLine(string.Join(" ", field));
//        }
//    }
//}