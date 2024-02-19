namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            List<string> cards = ReadList();

            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
               List<string> commands = ReadList();
                string command = commands[0];
                switch (command)
                {
                    case "Add":
                        cards = AddCard(cards, commands);
                        break;
                    case "Remove":
                        cards = RemoveCard(cards, commands);
                        break;
                    case "Remove At":
                        cards = RemoveAt(cards, commands);
                        break;
                    case "Insert":
                        cards = Insert(cards, commands);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }

        private static List<string> ReadList()
        {
            return Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        private static bool IndexisValid(List<string> cards, int index)
        {
            if (index < 0 || index >= cards.Count)
            {
                Console.WriteLine("Index out of range");
                return false;
            }

            return true;
        }
        private static List<string> AddCard(List<string> cards, List<string> commands)
        {
            string card = commands[1];
            if (cards.Contains(card))
            {
                Console.WriteLine("Card is already in the deck");
            }
            else
            {
                cards.Add(card);
                Console.WriteLine("Card successfully added");
            }
            return cards;
        }
        private static List<string> RemoveCard(List<string> cards, List<string> commands)
        {
            string card = commands[1];
            if (cards.Remove(card))
            {
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Card not found");
            }
            return cards;
        }
        private static List<string> RemoveAt(List<string> cards, List<string> commands)
        {
            int index = int.Parse(commands[1]);
            if (IndexisValid(cards, index))
            {
                cards.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
            return cards;
        }
        private static List<string> Insert(List<string> cards, List<string> commands)
        {
            int index = int.Parse(commands[1]);
            string card = commands[2];

            if (IndexisValid(cards, index))
            {
                if (cards.Contains(card))
                {
                    Console.WriteLine("Card is already added");
                }
                else
                {
                    cards.Insert(index, card);
                    Console.WriteLine("Card successfully added");
                }
            }

            return cards;
        }
    }
}