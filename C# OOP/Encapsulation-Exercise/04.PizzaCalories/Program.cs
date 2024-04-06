using _04.PizzaCalories;

string[] pizzaInfo = Console.ReadLine().Split();
try
{
    Pizza pizza = new Pizza(pizzaInfo[1]);
    string[] doughtInfo = Console.ReadLine().Split();
    Dough dough = new Dough(doughtInfo[1], doughtInfo[2], decimal.Parse(doughtInfo[3]));
    pizza.Dough = dough;
    string input;

    while ((input = Console.ReadLine()) != "END")
    {
        string[] toppingInfo = input.Split();

        Topping topping = new Topping(toppingInfo[1], decimal.Parse(toppingInfo[2]));
        pizza.AddTopping(topping);
    }

    Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    
}

