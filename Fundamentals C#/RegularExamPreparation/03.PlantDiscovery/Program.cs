using System.Xml.Linq;

int entries = int.Parse(Console.ReadLine());
Dictionary<string, Plant> plantCollection = new();

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

    string plant = input[0];
    string rarety = input[1];
    
    if (plantCollection.ContainsKey(plant) == false)
    {
        plantCollection.Add(plant, new Plant(plant, default));
    }
    plantCollection[plant].Rarety = rarety;
}

string commands;
while ((commands = Console.ReadLine()) != "Exhibition")
{
    string[] arguments = commands.Split(new [] {' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    string plant = arguments[1];


    if (plantCollection.ContainsKey(plant) == false)
    {
        Console.WriteLine("error");
        continue;
    }

    switch (command)
    {
        case "Rate":
                plantCollection[plant].Rate(arguments);
            break;
        case "Update":
            plantCollection[plant].Update(arguments);
            break;
        case "Reset":
            plantCollection[plant].Resset();
            break;
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (var (name, plant) in plantCollection)
{
    Console.WriteLine(plant);
}


class Plant
{

    private double rating;

    private int ratingCount; 
    
    public string Name { get; set; }
    public string Rarety { get; set; }

    public double AverageRating => rating / ratingCount ;


    public Plant(string name, string rarety)
    {
        Name = name;
        Rarety = rarety;
        ratingCount = 1;
    }

    public void Rate(string[] arguments)
    {
        double rating = double.Parse(arguments[2]);
        if (this.rating != 0)
        {
            ratingCount++;
        }
        this.rating += rating;

    }

    public void Update(string[] arguments)
    {
        string rarity = arguments[2];
        Rarety = rarity;
    }
    public void Resset()
    {
        ratingCount = 1;
        rating = 0;
    }

    public override string ToString()
    {
        return $"- {Name}; Rarity: {Rarety}; Rating: {AverageRating:f2}";
    }
}