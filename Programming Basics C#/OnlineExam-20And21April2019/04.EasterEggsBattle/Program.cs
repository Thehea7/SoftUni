

int player1Eggs = int.Parse(Console.ReadLine());
int player2Eggs = int.Parse(Console.ReadLine());

string winner = Console.ReadLine();

while (winner != "End")
{
    if (winner == "one")
    {
        player2Eggs--;
        if (player2Eggs == 0)
        {
            Console.WriteLine($"Player two is out of eggs. Player one has {player1Eggs} eggs left.");
            break;
        }
    }
   else if (winner == "two")
    {
        player1Eggs--;
        if (player1Eggs == 0)
        {
            Console.WriteLine($"Player one is out of eggs. Player two has {player2Eggs} eggs left.");
            break;
        }
    }


    winner = Console.ReadLine();
}
if (winner == "End")
{
    Console.WriteLine($"Player one has {player1Eggs} eggs left.");
    Console.WriteLine($"Player two has {player2Eggs} eggs left.");
}
