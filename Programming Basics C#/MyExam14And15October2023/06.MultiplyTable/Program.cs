
int input = int.Parse(Console.ReadLine());

int p1 = input % 10;
int p2 = input / 10 % 10;   
int p3 = input / 100 % 10;



for (int i = 1; i <= p1; i++)
{
    for (int j = 1; j <= p2; j++)
    {
        for (int k = 1; k <= p3; k++)
        {
            Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
        }
    }
}