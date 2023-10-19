/////


//int goal  = 10000;
//int stepsWalked = 0;
//bool goalReached = false;
//string input = "";

//while (!goalReached)
//{
//    input = Console.ReadLine();
//    if (input == "Going home")
//    {
//        int lastSteps = int.Parse(Console.ReadLine());
//        stepsWalked += lastSteps;
//        if (stepsWalked >= goal) goalReached = true;
//        break;
//    }
//    else
//    {
//        int moreSteps = int.Parse(input);
//        stepsWalked += moreSteps;
//    }
//    if (stepsWalked >= goal) goalReached = true;
//}

//if (goalReached)
//{
//    Console.WriteLine("Goal reached! Good job!");
//    Console.WriteLine($"{stepsWalked - goal} steps over the goal!");
//}
//else Console.WriteLine($"{goal - stepsWalked} more steps to reach goal.");

int goal = 10000;
int stepsWalked = 0;
bool goalReached = false;
string input = Console.ReadLine();

while (input != "Going home")
{
    
    int moreSteps = int.Parse(input);
    stepsWalked += moreSteps;
    if (stepsWalked >= goal)
    {
        goalReached = true;
        break;
    }
    input = Console.ReadLine();
}
if (!goalReached)
{
    int lastSteps = int.Parse(Console.ReadLine());
    stepsWalked += lastSteps;
    if (stepsWalked >= goal) goalReached = true; 
    
}
if (goalReached)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepsWalked - goal} steps over the goal!");
}
else Console.WriteLine($"{goal - stepsWalked} more steps to reach goal.");




