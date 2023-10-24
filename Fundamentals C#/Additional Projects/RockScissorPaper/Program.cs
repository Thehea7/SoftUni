const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
int you = 0;
int computer = 0;
Console.WriteLine("Your Name");
string name = Console.ReadLine();
Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

while (playerMove != "end")
{
    if (playerMove == "r" || playerMove == "rock")
    {
        playerMove = Rock;
    }
    else if (playerMove == "p" || playerMove == "paper")
    {
        playerMove = Paper;
    }
    else if (playerMove == "s" || playerMove == "scissors")
    {
        playerMove = Scissors;
    }
    else
    {
        Console.WriteLine("Invalid input. Try Again...");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
        playerMove = Console.ReadLine();
        continue;
    }

    Random random = new Random();
    int computerRandomnumber = random.Next(1, 4);
    string computerMove = "";

    switch (computerRandomnumber)
    {
        case 1:
            computerMove = Rock;
            break;
        case 2:
            computerMove = Paper;
            break;
        case 3:
            computerMove = Scissors;
            break;

    }

    Console.WriteLine($"The computer chose {computerMove}.");

    if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
    {
        Console.WriteLine($"{name} win.");
        you++;
        Console.WriteLine($"{name} {you}:{computer} Computer");

    }
    else if ((playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock) || (playerMove == Rock && computerMove == Paper))
    {
        Console.WriteLine("You lose.");
        computer++;
        Console.WriteLine($"{name} {you}:{computer} Computer");
    }
    else
    {
        Console.WriteLine("This game was a draw");
        Console.WriteLine($"{name} {you}:{computer} Computer");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
    playerMove = Console.ReadLine();
}

