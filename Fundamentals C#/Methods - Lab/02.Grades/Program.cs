namespace _02.Grades
{
    internal class Program
    {
        private static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            PrintCorrespondingGradeDefinition(grade);
        }

        private static void PrintCorrespondingGradeDefinition(double grade)
        {
            if (grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade < 3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade < 5.5)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}