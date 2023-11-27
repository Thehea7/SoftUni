namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] arguments = command.Split(":");

                if (arguments[0] == "Add")
                {
                    string lesson = arguments[1];
                    Add(input, lesson);
                }
                else if (arguments[0] == "Exercise")
                {
                    string lesson = arguments[1];
                    Exercise(input, lesson);
                }
                else if (arguments[0] == "Insert")
                {
                    string lesson = arguments[1];
                    int index = int.Parse(arguments[2]);
                    Insert(input, lesson, index);
                }
                else if (arguments[0] == "Remove")
                {
                    string lesson = arguments[1];
                    Remove(input, lesson);
                }
                else if (arguments[0] == "Swap")
                {
                    string lesson1 = arguments[1];
                    string lesson2 = arguments[2];
                    Swap(input, lesson1, lesson2);
                }

            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }


           

        }

        private static void Swap(List<string> input, string lesson1, string lesson2)
        {

            int index1 = input.IndexOf(lesson1);
            int index2 = input.IndexOf(lesson2);
            if (input.Contains(lesson1) && input.Contains(lesson2))
            {
                input[index1] = lesson2;
                input[index2] = lesson1;
            }

            if (input.Contains($"{lesson1}-Exercise"))
            {
                input.RemoveAt(input.IndexOf($"{lesson1}-Exercise"));
                input.Insert(input.IndexOf(lesson1) + 1, $"{lesson1}-Exercise");

            }
            if (input.Contains($"{lesson2}-Exercise"))
            {
                input.RemoveAt(input.IndexOf($"{lesson2}-Exercise"));
                input.Insert(input.IndexOf(lesson2) + 1, $"{lesson2}-Exercise");

            }
        }

        private static void Add(List<string> input, string lesson)
        {
            if (!input.Contains(lesson))
            {
                input.Add(lesson);
            }
        }
        private static void Remove(List<string> input, string lesson)
        {
            input.RemoveAll(x => x.Contains($"{lesson}"));
        }
        private static void Insert(List<string> input, string lesson, int index)
        {
            if (!input.Contains(lesson))
            {
                input.Insert(index, lesson);
            }
        }
        private static void Exercise(List<string> input, string lesson)
        {
            if (!input.Contains(lesson))
            {
                input.Add(lesson);
                input.Add($"{lesson}-Exercise");
            }
            else
            {
                if (!input.Contains($"{lesson}-Exercise"))
                {
                    int index = input.IndexOf(lesson) + 1;
                    input.Insert(index, $"{lesson}-Exercise");
                }
            }

        }

    }
}