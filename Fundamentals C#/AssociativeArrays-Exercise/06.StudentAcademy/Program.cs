namespace _06.StudentAcademy
{
    class Student
    {
        public string Name { get; set; }

        public List<decimal> Grades { get; set; }

        

        public Student(string name)
        {
            Name = name;
            
            Grades = new List<decimal>();
        }

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Student> studentsMap = new Dictionary<string, Student>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                Student student = new Student(name);
                if (!studentsMap.ContainsKey(name))
                {
                    studentsMap.Add(name, student);
                }
                studentsMap[name].Grades.Add(grade);
            }

            var filteredStudents = studentsMap.Where(x => x.Value.Grades.Average() >= 4.5m);
          
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.Value);
            }
        }
    }
}