﻿var age = int.Parse(Console.ReadLine());

if  (age >= 0 && age <= 2)
{
    Console.WriteLine("baby");
}
else if (age >= 3 && age <= 13)
{
    Console.WriteLine("child");
}
else if (age >= 14 && age <= 19)
{
    Console.WriteLine("teenager");
}
else if (age > 19 && age < 66)
{
    Console.WriteLine("adult");
}
else if (age > 65)
{
    Console.WriteLine("elder");
}