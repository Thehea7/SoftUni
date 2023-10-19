


// Read Input

int alowedFailedGrades = int.Parse(Console.ReadLine());
string problem = "none";
int failedgrades = 0;
int totalProblems = 0;
int totalGrade = 0;
bool failed = false;
string lastProblem = "text";


while (failedgrades < alowedFailedGrades)
{
    lastProblem = problem;
    problem = Console.ReadLine();
    if (problem == "Enough") break;
    
    int currentGrade = int.Parse(Console.ReadLine());
    totalGrade += currentGrade;
    if (currentGrade <= 4) failedgrades++;
    totalProblems++;
    if (failedgrades == alowedFailedGrades)
    {
        failed = true;
        break;
    }
}

if (failed)
{
    Console.WriteLine($"You need a break, {alowedFailedGrades} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {1.0 * totalGrade / totalProblems:f2}");
    Console.WriteLine($"Number of problems: {totalProblems}");
    Console.WriteLine($"Last problem: {lastProblem}");
}