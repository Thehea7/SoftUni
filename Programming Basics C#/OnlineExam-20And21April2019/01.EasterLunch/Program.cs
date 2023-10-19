
int kosunak = int.Parse(Console.ReadLine());
int eggs = int.Parse(Console.ReadLine());
int cookies  = int.Parse(Console.ReadLine());

double expenses = kosunak * 3.2 + cookies * 5.4 + eggs * 4.35 + eggs * 12 * 0.15;

Console.WriteLine($"{expenses:f2}");