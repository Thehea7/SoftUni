namespace _05.Courses
{
    class Course
    {
        public string Name { get; set; }

        public List<string> Students { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new List<string>();
        }

        public override string ToString()
        {
            return $"{Name}: {Students.Count}\n-- {string.Join("\n-- ", Students)}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" : ");
                string name = arguments[0];
                string student = arguments[1];

                if (!coursesMap.ContainsKey(name))
                {
                    coursesMap.Add(name, new Course(name));
                }
                coursesMap[name].Students.Add(student);
            }

            foreach (var course in coursesMap)
            {
                Console.WriteLine(course.Value);
            }
            

        }
    }
}