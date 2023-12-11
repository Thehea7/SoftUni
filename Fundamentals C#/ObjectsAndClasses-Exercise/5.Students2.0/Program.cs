using System.Security.Cryptography;

namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            string input = string.Empty;

            List<Student> list = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split();
                int age = int.Parse(studentInfo[2]);
                Student currentStudent = new Student(studentInfo[0], studentInfo[1], age, studentInfo[3]);
      
                    bool isFound = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].FirstName == currentStudent.FirstName && list[i].LastName == currentStudent.LastName)
                        {
                            list[i].Age = age;
                            list[i].HomeTown = currentStudent.HomeTown;
                            isFound = true;
                            break;
                        }
                        

                    }
                    if (!isFound)
                    {
                        list.Add(currentStudent);
                    }
           
            }
            string cityName = Console.ReadLine();

            foreach (Student student in list)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    class Student
    {
        public Student(string name, string lastName, int age, string home)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            HomeTown = home;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}