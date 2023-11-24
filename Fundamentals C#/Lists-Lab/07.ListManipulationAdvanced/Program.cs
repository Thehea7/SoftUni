namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> output = input.ToList();
           
            

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "Add")
                {
                    output.Add(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Remove")
                {
                    output.Remove(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "RemoveAt")
                {
                    output.RemoveAt(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Insert")
                {
                    output.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Contains")
                {
                    ContainsNumber(output, arguments[1]);
                }
                else if (arguments[0] == "PrintEven")
                {
                    Printeven(output);
                }
                else if (arguments[0] == "PrintOdd")
                {
                    PrintOdd(output);
                }
                else if (arguments[0] == "GetSum")
                {
                    Console.WriteLine(output.Sum());
                }
                else if (arguments[0] == "Filter")
                {
                    PrintFilter(output, arguments[1], arguments[2]);
                }
                
            }
            bool areEqual = true;
            if (output.Count == input.Length)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i] != input[i])
                    {
                        areEqual = false; break;
                    }
                }
            }
            else { areEqual = false; }

            if (!areEqual)
            {
                Console.WriteLine(string.Join(" ", output));
            }
            

        }

        private static void PrintFilter(List<int> output, string argument, string compareWithnumber)
        {
            int number = int.Parse(compareWithnumber);
            switch (argument)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", output.FindAll(x => x < number)));
                    
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", output.FindAll(x => x > number)));
                    
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", output.FindAll(x => x >= number)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", output.FindAll(x => x <= number)));
                    break;
            }
        }

        private static void Printeven(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input.FindAll(x => x % 2 == 0)));
        }
        private static void PrintOdd(List<int> input)
        {
            //input.FindAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", input.FindAll(x => x % 2 != 0)));
        }

        private static void ContainsNumber(List<int> output, string argument)
        {
            int number = int.Parse(argument);

            if (output.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }

        }
    }
}