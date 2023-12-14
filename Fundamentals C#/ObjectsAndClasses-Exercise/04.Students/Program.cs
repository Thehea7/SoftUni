namespace _04.Students
{

    class Student
    {
        public Student(string v1, string v2, double grade)
        {
            Firstname = v1;
            Lastname = v2;
            Grade = grade;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}: {Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray(); 
                double grade = double.Parse(input[2]);
                Student student = new Student(input[0], input[1], grade);
                students.Add(student);
            }
            List<Student> orderedList= students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in orderedList)
            {
                Console.WriteLine(student);
            }
        }
    }
}