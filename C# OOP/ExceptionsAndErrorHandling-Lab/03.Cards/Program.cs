
using System.Runtime.CompilerServices;
Card Getcard(string cardInfo)
{
    string[] str = cardInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string face = str[0];
    string suit = str[1];

    return new Card(face, suit);
}


string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
List<Card> cards = new List<Card>();
for (int i = 0; i < input.Length; i++)
{
    try
    {
        cards.Add(Getcard(input[i]));
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine(string.Join(" ", cards));

public class Card
{
    private string face;
    private string suit;

    private List<string> faces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private Dictionary<string, char> suits = new Dictionary<string, char>() { { "S", '\u2660' }, { "H", '\u2665' }, { "D", '\u2666' }, { "C", '\u2663' } };

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }
    public string Face
    {
        get => face;
        set
        {
            if (faces.Contains(value) == false)
            {
                throw new ArgumentException("Invalid card!");
            }
            face = value;
        }
    }

    public string Suit
    {
        get => suit;
        set
        {
            if (suits.ContainsKey(value) == false)
            {
                throw new ArgumentException("Invalid card!");
            }
            suit = value;
        }
    }

    public override string ToString()
    {
        return $"[{face}{suits[suit]}]";
    }
}

