

// Read Input

int age = int.Parse(Console.ReadLine());
double priceWashingmashine  = double.Parse(Console.ReadLine());
int pricePerToy = int.Parse(Console.ReadLine());

// Calculations
int toys = 0;
int giftedMoney = 0;
int totalGiftedMoney = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 != 0) toys++;
    else
    {
        giftedMoney += 10;
        totalGiftedMoney += giftedMoney - 1;
    }
}

double totalMoney = totalGiftedMoney + pricePerToy * toys;

// Print Output

if (totalMoney >= priceWashingmashine)
{
    Console.WriteLine($"Yes! {totalMoney - priceWashingmashine:f2}");
}
else
{
    Console.WriteLine($"No! {priceWashingmashine - totalMoney:f2}");
}