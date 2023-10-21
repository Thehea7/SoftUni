char a = char.Parse(Console.ReadLine());


for (char i = 'a'; i <= 'z'; i++)
{
    if (a == i)
    {
        Console.WriteLine("lower-case");
        break;
    }
}
for (char i = 'A'; i <= 'Z'; i++)
{
    if (a == i)
    {
        Console.WriteLine("upper-case");
        break;
    }
}


