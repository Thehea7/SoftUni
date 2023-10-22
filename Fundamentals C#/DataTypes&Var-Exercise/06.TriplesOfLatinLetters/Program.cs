int n = int.Parse(Console.ReadLine());

for (char i = 'a'; i < 'a' + n; i++)
{
    for (char c = 'a'; c < 'a' + n; c++)
    {
        for (char c2 = 'a'; c2 < 'a' + n; c2++)
        {
            Console.WriteLine($"{i}{c}{c2}");
        }
    }
}