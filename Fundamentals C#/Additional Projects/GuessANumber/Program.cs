Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);
Console.WriteLine("Your name: ");
string name = Console.ReadLine();
int attempts = 0;

while (true)
{
    Console.WriteLine("Guess a number (1-100): ");
    string input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int playerNumber);

    if (isValid)
    {
        if (playerNumber == computerNumber)
        {
            Console.WriteLine($"Congatulations {name}, You guessed it after {attempts} failed attempts");
            break;
        }
        else if (playerNumber > computerNumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too Low");
        }
        attempts++;
    }
    else { Console.WriteLine("Invalid input."); }
}
