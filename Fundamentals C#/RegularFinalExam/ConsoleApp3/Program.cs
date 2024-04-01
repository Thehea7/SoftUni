
Dictionary<string, Follower> followers = new();

string commands;
while ((commands = Console.ReadLine()) != "Log out")
{
    string[] arguments = commands.Split(": ", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    string name = arguments[1];

    switch (command)
    {
        case "New follower":
            Add(followers, name);
            break;
        case "Like":
            int likes = int.Parse(arguments[2]);
            Add(followers, name);
            followers[name].Likes+= likes;
            break;
        case "Comment":
            Add(followers, name);
            followers[name].Comments++;
            break;
        case "Blocked":
            Block(followers, name);
            break;
    }
}

Console.WriteLine($"{followers.Count} followers");
foreach (var (name, follower) in followers)
{
    Console.WriteLine(follower);
}



static void Block(Dictionary<string, Follower> followers, string name)
{
    if (followers.ContainsKey(name) == false)
    {
        Console.WriteLine($"{name} doesn't exist.");
        return;
    }

    followers.Remove(name);

}
static void Add(Dictionary<string, Follower> followers, string name)
{
    if (followers.ContainsKey(name) == false)
    {
        followers.Add(name, new Follower(name));
    }
}

class Follower
{
    public Follower(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Likes { get; set; }
    public int Comments { get; set; }

    public override string ToString()
    {
        return $"{Name}: {Likes + Comments}";
    }
}