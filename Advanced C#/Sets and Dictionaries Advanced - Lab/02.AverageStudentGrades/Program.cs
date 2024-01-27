namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {

                    students.Add(name, new List<decimal>());
                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {student.Value.Average():f2})");
            }


            //foreach (var student in students)
            //{
            //    Console.Write($"{student.Key} -> ");

            //    foreach (var grade in student.Value)
            //    {
            //        Console.Write($"{grade:f2} ");
            //    }

            //    Console.WriteLine($"(avg: {student.Value.Average():f2})");
            //}

        }
    }
}