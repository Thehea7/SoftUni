

// Read Input

int students = int.Parse(Console.ReadLine());
double totalGrades = 0;
int weakStudent = 0;
int passStudents = 0;
int goodStudents = 0;
int veryGoodStudents = 0;


for (int i = 0; i < students; i++)
{
    double currentGrade = double.Parse(Console.ReadLine());
    totalGrades += currentGrade;
    if (currentGrade < 3) weakStudent ++;
    else if (currentGrade < 4) passStudents ++;
    else if (currentGrade < 5) goodStudents ++;
    else if (currentGrade <= 6) veryGoodStudents ++;

}

Console.WriteLine($"Top students: {100.00 * veryGoodStudents / students:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {100.00 * goodStudents / students:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {100.00 * passStudents / students:f2}%");
Console.WriteLine($"Fail: {100.00 * weakStudent / students:f2}%");
Console.WriteLine($"Average: {totalGrades / students:f2}");