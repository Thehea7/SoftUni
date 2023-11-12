namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string commanda = "";
            input = CheckCommand(input);

            string output = string.Join(", ", input);
            Console.WriteLine('[' + output + ']');
        
        }

        private static int[] CheckCommand(int[] input)
        {
            string commanda;
            while ((commanda = Console.ReadLine()) != "end")
            {
                string[] command = commanda.Split();
                if (command[0] == "exchange")
                {
                    input = Exchange(command, input);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "odd")
                    {
                        MaxOddIndex(input);
                    }
                    else if (command[1] == "even")
                    {
                        MaxEvenIndex(input);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "odd")
                    {
                        MinOddIndex(input);
                    }
                    else if (command[1] == "even")
                    {
                        MinEvenIndex(input);
                    }
                }
                else if (command[0] == "first")
                {
                    if (command[2] == "odd")
                    {
                        FirstNOdd(command, input);
                    }
                    else if (command[2] == "even")
                    {
                        FirstNEven(command, input);
                    }
                }
                else if (command[0] == "last")
                {
                    if (command[2] == "even")
                    {
                        LastNEven(command, input);
                    }
                    else if (command[2] == "odd")
                    {
                        LastNOdd(command, input);
                    }
                }
            }

            return input;
        }

        private static void LastNEven(string[] command, int[] input)
        {
            int lastElements = int.Parse(command[1]);
            if (lastElements > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string output = "";
                int count = 0;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (count + 1 == lastElements)
                        {
                            output += input[i];
                            break;
                        }

                        output += $"{input[i]} ,";
                        count++;
                    }
                }

                string[] outputArr = output.Split(" ,");
                Array.Reverse(outputArr);
                string reversedOutput = string.Join(", ", outputArr);
                Console.WriteLine('[' + reversedOutput.Trim(',', ' ') + ']');
            }
        }

        private static void LastNOdd(string[] command, int[] input)
        {
            int lastElements = int.Parse(command[1]);
            if (lastElements > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string output = "";
                int count = 0;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (count + 1 == lastElements)
                        {
                            output += input[i];
                            break;
                        }

                        output += $"{input[i]} ,";
                        count++;
                    }
                }

                string[] outputArr = output.Split(" ,");
                Array.Reverse(outputArr);
                string reversedOutput = string.Join(", ", outputArr);
                Console.WriteLine('[' + reversedOutput.Trim(',', ' ') + ']');
            }
        }

        private static int[] Exchange(string[] command, int[] input)
        {
            int splitIndex = int.Parse(command[1]);
            int[] output = new int[input.Length];
            if (splitIndex >= input.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                output = input;
            }
            else
            {
                int count = 0;
                for (int i = splitIndex + 1, j = 0; i < input.Length; i++, j++)
                {
                    output[j] += input[i];
                    count++;
                }

                for (int i = 0, j = count; i <= splitIndex; i++, j++)
                {
                    output[j] += input[i];
                }
            }
            
            return output;
        }

        private static void MinEvenIndex(int[] input)
        {
            int minEvenIndex = 0;
            int minEven = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= minEven && input[i] % 2 == 0)
                {
                    minEvenIndex = i;
                    minEven = input[i];
                }
            }

            if (minEven == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenIndex);
            }
        }

        private static void MaxEvenIndex(int[] input)
        {
            int maxEvenIndex = 0;
            int maxEven = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= maxEven && input[i] % 2 == 0)
                {
                    maxEvenIndex = i;
                    maxEven = input[i];
                }
            }

            if (maxEven == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenIndex);
            }
        }
        
        private static void MinOddIndex(int[] input)
        {
            int minOddIndex = 0;
            int minOdd = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= minOdd && input[i] % 2 != 0)
                {
                    minOddIndex = i;
                    minOdd = input[i];
                }
            }

            if (minOdd == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddIndex);
            }
        }

        private static void MaxOddIndex(int[] input)

        {
            int maxOddIndex = 0;
            int maxOdd = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= maxOdd && input[i] % 2 != 0)
                {
                    maxOddIndex = i;
                    maxOdd = input[i];
                }
            }

            if (maxOdd == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddIndex);
            }
        }
        private static void FirstNOdd(string[] command, int[] input)
        {
            int firstelements = int.Parse(command[1]);
            if (firstelements > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string output = "";
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (count + 1 == firstelements)
                        {
                            output += input[i];
                            break;
                        }

                        output += $"{input[i]}, ";
                        count++;
                    }
                }

                Console.WriteLine('[' + output.Trim(' ', ',') + ']');
            }
        }
        private static void FirstNEven(string[] command, int[] input)
        {
            int firstelements = int.Parse(command[1]);
            if (firstelements > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string output = "";
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (count + 1 == firstelements)
                        {
                            output += input[i];
                            break;
                        }

                        output += $"{input[i]}, ";
                        count++;
                    }
                }

                Console.WriteLine('[' + output.Trim(' ', ',') + ']');
            }
        }
    }

}