

int juriN = int.Parse(Console.ReadLine());
string presentation  = Console.ReadLine();
double totalAverage = 0;
int presentationCount = 0;

while (presentation != "Finish")
{
    presentationCount++;
    double gradeSum = 0;
    for (int i = 0; i < juriN; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradeSum += grade;
    }
    double gradeAverage = gradeSum / juriN;
    totalAverage += gradeAverage;
    Console.WriteLine($"{presentation} - {gradeAverage:f2}.");

    presentation = Console.ReadLine();
}
Console.WriteLine($"Student's final assessment is {totalAverage / presentationCount:f2}.");