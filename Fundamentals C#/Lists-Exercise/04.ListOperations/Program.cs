namespace _04.ListOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "Add")
                {
                    int number = int.Parse(arguments[1]);
                    input.Add(number);
                }
                else if (arguments[0] == "Insert")
                {
                    int number = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);
                    if (CheckIndex(input, index))
                    {
                        //OutOfRange
                    }
                    else
                    {
                        input.Insert(index, number);
                    }
                }
                else if (arguments[0] == "Remove")
                {
                    int index = int.Parse(arguments[1]);
                    if (CheckIndex(input, index))
                    {
                        //OutOfRange
                    }
                    else
                    {
                        input.RemoveAt(index);
                    }
                }
                else if (arguments[0] == "Shift")
                {
                    string destination = arguments[1];
                    int count = int.Parse(arguments[2]);
                    Shift(input, destination, count);
                }

            }

            Console.WriteLine(string.Join(" ", input));
            
        }

        private static bool CheckIndex(List<int> input, int index)
        {
            if (index < 0 || index >= input.Count)
            {
                Console.WriteLine("Invalid index");
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void Shift(List<int> input, string destination, int count)
        {
            if (destination == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int firtsNumber = input[0];
                    input.RemoveAt(0);
                    input.Add(firtsNumber);
                }
            }
            else if (destination == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    int lastNumber = input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    input.Insert(0, lastNumber);
                }
            }
        }
    }
}