double rent = double.Parse(Console.ReadLine());
double cake = rent * 0.2;
double drinks = 0.55 * cake;
double animation = 1.0 * rent / 3;
double requiredbudget = rent + cake + drinks + animation;

Console.WriteLine($"{requiredbudget}");