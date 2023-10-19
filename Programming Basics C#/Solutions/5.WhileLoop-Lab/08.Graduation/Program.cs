
string name = Console.ReadLine();
int grade = 1;
double totalEvaluation = 0;
int expelled = 0;


while (grade < 13)
{
    double evaluation = double.Parse(Console.ReadLine());
    
    if (evaluation >= 4)
    {
        grade++;
        totalEvaluation += evaluation;
    }
    else
    {
        expelled++;
        if (expelled > 1)
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            break;
        }
    }
    
}
if (grade > 12)
Console.WriteLine($"{name} graduated. Average grade: {totalEvaluation / 12.0:f2}");