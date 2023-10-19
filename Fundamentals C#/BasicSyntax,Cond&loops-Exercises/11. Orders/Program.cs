int orders = int.Parse(Console.ReadLine());

double total = 0;

for  (int i = 0; i < orders; i++)
{
    double pricePerCapsul = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    double orderPrice = days * capsulesCount * pricePerCapsul;
    Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
    total += orderPrice;
}
Console.WriteLine($"Total: ${total:f2}");