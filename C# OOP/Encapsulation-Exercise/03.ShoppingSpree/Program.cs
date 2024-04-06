using _03.ShoppingSpree;

Dictionary<string, Person>  people = new();
Dictionary<string, Product>  products = new();

string[] arguments = Console.ReadLine().Split(new []{'=', ';'}, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < arguments.Length; i+=2)
{
    string name = arguments[i];
    decimal money = decimal.Parse(arguments[i + 1]);
    try
    {
        Person person = new Person(name, money);
        people.Add(name, person);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

arguments = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < arguments.Length; i += 2)
{
    string name = arguments[i];
    decimal price = decimal.Parse(arguments[i + 1]);
    try
    {
        Product product = new Product(name, price);
        products.Add(name, product);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

string commands;

while ((commands = Console.ReadLine()) != "END")
{
    string[] inputSplit = commands.Split();

    string name = inputSplit[0];
    string productName = inputSplit[1];
    people[name].AddProduct(products[productName]);
}

foreach (var (name, person) in people)
{
    Console.WriteLine(person);
}

