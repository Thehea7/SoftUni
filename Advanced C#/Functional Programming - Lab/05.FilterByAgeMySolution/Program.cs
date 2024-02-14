using System;
using System.Threading.Channels;

namespace _05.FilterByAgeMySolution
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
        static void Main()
        {
            List<Student> students = ReadPeople();

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Student, bool> filter = CreateFilter(condition, ageFilter);

            Func<Student, string> printer = CreatePrinter(format);

            PrintFilteredPeople(students, filter, printer);

        }

         private static void PrintFilteredPeople(List<Student> students, Func<Student, bool> filter, Func<Student, string> printer)
        {
            foreach (var student in students
                         .Where(filter))
            {
                Console.WriteLine(printer(student));
            }
        }

        public static Func<Student, bool> CreateFilter(string condition, int ageFilter)
        {
            if (condition == "older")
            {
                return x => x.Age >= ageFilter;
            }

            if (condition == "younger")
            {
                return x => x.Age < ageFilter;
            }

            return null;
        }
        public static List<Student> ReadPeople()
        {
            int itterations = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < itterations; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                int age = int.Parse(input[1]);
                string name = input[0];
                students.Add(new Student(name, age));
            }

            return students;
        }

        public static Func<Student, string> CreatePrinter(string format)
        {
            if (format == "name")
                return x => x.Name;
            if (format == "age")
                return x => x.Age.ToString();
            if (format == "name age")
                return x => $"{x.Name} - {x.Age}";
            return null;
        }
    }
}