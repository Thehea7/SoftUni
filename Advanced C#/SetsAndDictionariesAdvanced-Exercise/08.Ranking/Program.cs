namespace _08.Ranking
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            Courses = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public int TotalPoints { get; set; }
        public Dictionary<string, int> Courses { get; set; }

        public override string ToString()
        {
            string output = $"{Name}";
            
                foreach (var (course, points) in Courses.OrderByDescending(x => x.Value))
                {
                    output += $"\n#  {course} -> {points}";
                }

                return output;
        }
    }
    internal class Program
    {
        static void Main()
        {
            string commands;
            Dictionary<string, string> contestsDictionary = new Dictionary<string, string>();
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            while ((commands = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = commands.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = arguments[0];
                string password = arguments[1];
                contestsDictionary[contest] = password;
            }

            while ((commands = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = commands.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = arguments[0];
                string password = arguments[1];
                string name = arguments[2];
                int points = int.Parse(arguments[3]);

                if (IsValid(contestsDictionary, arguments))
                {
                    if (!students.ContainsKey(name))
                    {
                        Student student = new Student(name);
                        students.Add(name, student);
                    }
                    if (!students[name].Courses.ContainsKey(contest))
                    {
                        students[name].Courses.Add(contest, points);
                        students[name].TotalPoints += points;
                    }

                    if (students[name].Courses[contest] < points)
                    {
                        students[name].TotalPoints += points - students[name].Courses[contest];
                        students[name].Courses[contest] = points;
                    }

                }
            }

            string bestStudent = students.OrderByDescending(x => x.Value.TotalPoints).First().Key;

            Console.WriteLine($"Best candidate is {bestStudent} with total {students[bestStudent].TotalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Value);
            }
        }

        private static bool IsValid(Dictionary<string, string> contestsDictionary, string[] arguments)
        {
            string contest = arguments[0];
            string password = arguments[1];
            if (!contestsDictionary.ContainsKey(contest)
               || contestsDictionary[contest] != password)
                return false;

            return true;
        }
    }
}