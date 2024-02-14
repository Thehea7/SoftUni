namespace _05.FilterByAge
{

    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                students.Add(new Student(name, age));
            }

            string filterType = Console.ReadLine();//older or younger
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Student, int, bool> filter = FilterGenerator(filterType);

            students = students
                .Where(student => filter(student, ageFilter))
                .ToList();

            Action<Student> Printer = PrintFilteredStudents(format);

            students.ForEach(student => Printer(student));
        }

        public static Action<Student> PrintFilteredStudents(string format)
        {
            if (format == "name age")
            {
                return s => Console.WriteLine($"{s.Name} - {s.Age}");
            }
            if (format == "name")
            {
                return s => Console.WriteLine($"{s.Name}");
            }
            if (format == "age")
            {
                return s => Console.WriteLine($"{s.Age}");
            }

            return null;
        }

        public static Func<Student, int, bool> FilterGenerator(string filterType)
        {
            Func<Student, int, bool> filter = null;
            if (filterType == "older")
            {
                filter = (student, number) => student.Age >= number;
            }
            if (filterType == "younger")
            {
                filter = (student, number) => student.Age < number;
            }

            return filter;
        }
    }
}