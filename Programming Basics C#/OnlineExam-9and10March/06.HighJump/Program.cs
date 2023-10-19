int target = int.Parse(Console.ReadLine());
int currentJump = int.Parse(Console.ReadLine());
int startingTarget = target - 30;
bool isFailed = false;
int failedAttempt = 0;
int totaljumps = 1;

while (startingTarget <= target)
{

    if (currentJump <= startingTarget)
    {
        failedAttempt++;

        if (failedAttempt == 3)
        {
            isFailed = true;
            break;
        }
        currentJump = int.Parse(Console.ReadLine());
        totaljumps++;
        continue;
    }
    if (startingTarget == target) break;
    failedAttempt = 0;
    startingTarget += 5;
    totaljumps++;
    currentJump = int.Parse(Console.ReadLine());
}

if (isFailed)
{
    Console.WriteLine($"Tihomir failed at {startingTarget}cm after {totaljumps} jumps.");
}
else
{
    Console.WriteLine($"Tihomir succeeded, he jumped over {target}cm after {totaljumps} jumps.");
}




