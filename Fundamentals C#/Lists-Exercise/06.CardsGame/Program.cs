namespace _06.CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> deck1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> deck2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (deck1.Count != 0 && deck2.Count != 0)
            {
                if (deck1[0] > deck2[0])
                {
                    int player1Card = deck1[0];
                    int player2Card = deck2[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck1.Add(player1Card);
                    deck1.Add(player2Card);
                }
                else if (deck2[0] > deck1[0])
                {
                    int player1Card = deck1[0];
                    int player2Card = deck2[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck2.Add(player2Card);
                    deck2.Add(player1Card);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }

            }

            if (deck1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }


        }
    }
}