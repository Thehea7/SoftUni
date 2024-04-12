Dictionary<int, double> accounts = new Dictionary<int, double>();

string[] input = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < input.Length; i += 2)
{
    int id = int.Parse(input[i]);
    double balance = double.Parse(input[i + 1]);
    accounts.Add(id, balance);
}

string commands;

while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();
    try
    {
         ProcessCommands(arguments);
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine("Enter another command");
    }
    

}




void ProcessCommands(string[] arguments)
{
    string command = arguments[0];
    int accId = int.Parse(arguments[1]);
    double amount = double.Parse(arguments[2]);
    if (accounts.ContainsKey(accId) == false)
    {
        throw new InvalidOperationException("Invalid account!");
    }
    switch (command)
    {
        case "Deposit":
           Deposit(accId, amount);
            break;
        case "Withdraw":
            Withdraw(accId, amount);
            break;
        default:
            throw new InvalidOperationException("Invalid command!");
    }

    Console.WriteLine($"Account {accId} has new balance: {accounts[accId]:f2}");
}


void Deposit(int accId, double amount)
{
    accounts[accId] += amount;
}
void Withdraw(int accId, double amount)
{
    if (accounts[accId] - amount < 0)
    {
        throw new InvalidOperationException("Insufficient balance!");
    }

    accounts[accId] -= amount;
}