
string player1 = Console.ReadLine();
string player2 = Console.ReadLine();

string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

int player1Points = 0;
int player2Points = 0;
bool isWar = false;

while (input1 != "End of game")
{
    int card1 = int.Parse(input1);
    int card2 = int.Parse(input2);
    if (isWar == true)
    {
        Console.WriteLine("Number wars!");
        if (card1 > card2)
        {
            Console.WriteLine($"{player1} is winner with {player1Points} points");
            break;
        }
        else if (card1 < card2) 
        {
            Console.WriteLine($"{player2} is winner with {player2Points} points");
            break;
        }
    }
    if (card1 == card2)
    {
        isWar = true;

    }
    else
    {
        if (card1 > card2)  player1Points += (card1 - card2); 
        else player2Points += (card2 - card1);
    }


    input1 = Console.ReadLine();
    if (input1 == "End of game") break;
    input2 = Console.ReadLine();


}
if (!isWar)
{
    Console.WriteLine($"{player1} has {player1Points} points");
    Console.WriteLine($"{player2} has {player2Points} points");

}
