

int vaucherValue = int.Parse(Console.ReadLine());

string purchase = Console.ReadLine();
int tickets = 0;
int others = 0;

while (purchase != "End")
{
    if (purchase.Length > 8)
    {
        vaucherValue -= (purchase[0] + purchase[1]);
        if (vaucherValue < 0) break;
        tickets++;
    }
    else
    {
        vaucherValue -= purchase[0];
        if (vaucherValue < 0) break;
        others++;
    }

    purchase = Console.ReadLine();
}
Console.WriteLine(tickets);
Console.WriteLine(others);