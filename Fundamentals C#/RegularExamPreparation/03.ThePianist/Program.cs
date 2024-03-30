using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

int entries = int.Parse(Console.ReadLine());
List<Piece> startingPieces = new();

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    Piece piece = new Piece(input[0], input[1], input[2]);
    startingPieces.Add(piece);
}

Pieces pieces = new Pieces(startingPieces);
string commands;
while ((commands = Console.ReadLine()) != "Stop")
{
    string[] arguments = commands.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    switch (command)
    {
        case "Add":
            pieces.Add(arguments);
            break;
        case "Remove":
            pieces.Remove(arguments);
            break;
        case "ChangeKey":
            pieces.ChangeKey(arguments);
            break;
    }
}

pieces.Print();


class Piece
{
    public Piece(string name, string composer, string key)
    {
        Name = name;
        Composer = composer;
        Key = key;
    }

    public string Name { get; set; }
    public string Composer { get; set; }
    public string Key { get; set; }

    public override string ToString()
    {
        return $"{Name} -> Composer: {Composer}, Key: {Key}";
    }
}

class Pieces : IEnumerable<Piece>
{
    private List<Piece> pieces;

    public Pieces(List<Piece> pieces)
    {
        this.pieces = pieces;
    }

    public void Add(string[] input)
    {
        string name = input[1];
        string composer = input[2];
        string key = input[3];
        if (pieces.Exists(x => x.Name == name) == false)
        {
            pieces.Add(new Piece(name, composer, key));
            Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
        }
        else
        {
            Console.WriteLine($"{name} is already in the collection!");
        }

    }

    public void Remove(string[] input)
    {
        string name = input[1];
        if (pieces.Exists(x => x.Name == name))
        {
            pieces.RemoveAll(x => x.Name == name);
            Console.WriteLine($"Successfully removed {name}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
        }
    }

    public void ChangeKey(string[] input)
    {
        string name = input[1];
        string newKey = input[2];

        if (pieces.Exists(x => x.Name == name))
        {
            pieces[pieces.FindIndex(x => x.Name == name)].Key = newKey;
            Console.WriteLine($"Changed the key of {name} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
        }
    }

    public void Print()
    {
        foreach (var piece in pieces)
        {
            Console.WriteLine(piece);
        }
    }

    public IEnumerator<Piece> GetEnumerator()
    {
        return pieces.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}