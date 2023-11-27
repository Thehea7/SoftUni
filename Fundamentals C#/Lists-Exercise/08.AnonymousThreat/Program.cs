namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "merge")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    Merge(input, startIndex, endIndex);
                }
                else if (arguments[0] == "divide")
                {
                    int index = int.Parse(arguments[1]);
                    int parts = int.Parse(arguments[2]);
                    Divide(input, index, parts);
                }

                

            }

            Console.WriteLine(string.Join(" ", input));



        }
        private static void Merge(List<string> input, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex >= input.Count)
            {
                startIndex = input.Count - 1;
            }

            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }
            string result = string.Empty;
            int itterations = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                result += input[i];
                itterations++;
            }
            input.RemoveRange(startIndex, itterations);
            input.Insert(startIndex, result);
        }

        private static void Divide(List<string> input, int index, int parts)
        {
            List<string> newList = new List<string>();
            List<string> currentString = new List<string>();
            foreach (char c in input[index])
            {
                currentString.Add(c.ToString());
            }
            int chars = currentString.Count / parts;
            for (int i = 1; i <= parts; i++)
            {
                string partition = String.Empty;
                if (i == parts)
                {
                    for (int j = 0; j < currentString.Count; j++)
                    {
                        partition += currentString[j];
                    }
                }
                else
                {
                    for (int j = 0; j < chars; j++)
                    {
                        partition += currentString[j];
                    }
                }
                currentString.RemoveRange(0, chars);
                newList.Add(partition);
            }

            input.RemoveAt(index);
            input.InsertRange(index, newList);
        }

    }
}