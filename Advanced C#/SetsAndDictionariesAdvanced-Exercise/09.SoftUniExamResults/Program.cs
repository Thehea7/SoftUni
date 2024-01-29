namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> courses = new Dictionary<string, int>();
            Dictionary<string, int> students = new Dictionary<string,int>();

            string commands;
            while ((commands = Console.ReadLine()) != "exam finished")
            {
                string[] arguments = commands.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string studentName = arguments[0];
                string command = arguments[1];
                if (command == "banned")
                {
                    students.Remove(studentName);
                }
                else
                {
                    string course = command;
                    int points = int.Parse(arguments[2]);
                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, 0);
                    }
                    courses[course]++;

                    if (!students.ContainsKey(studentName))
                    {
                        students.Add(studentName, points);
                    }

                    if (students[studentName] < points)
                    {
                        students[studentName] = points;
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var (student, score) in students
                         .OrderByDescending(x => x.Value)
                         .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student} | {score}");
            }
            Console.WriteLine("Submissions:");
            foreach (var (course, submissions) in courses
                         .OrderByDescending(x => x.Value)
                         .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{course} - {submissions}");
            }

        }
    }
}