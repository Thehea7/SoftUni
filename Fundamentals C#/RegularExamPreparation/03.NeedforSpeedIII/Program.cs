using System.Runtime.InteropServices;

int entries = int.Parse(Console.ReadLine());
Dictionary<string, Car> cars = new Dictionary<string, Car>();

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    string brand =input[0];
    int mileage = int.Parse(input[1]);
    int fuel = int.Parse(input[2]);

    if (cars.ContainsKey(brand) == false)
    {
        cars.Add(brand, default);
    }
    cars[brand] = new Car()
    {
        Brand    = brand, Mileage = mileage, Fuel = fuel
    };
}

string commands;
while ((commands = Console.ReadLine()) != "Stop")
{
    string[] arguments = commands.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    string car = arguments[1];

    switch (command)
    {
        case "Drive":
            cars[car].Drive(arguments);
            CheckMileage(cars, car);
            break;
        case "Refuel":
            cars[car].Refuel(arguments);
            break;
        case "Revert":
            cars[car].Revert(arguments);
            break;
    }
}

foreach (var (name, car) in cars)
{
    Console.WriteLine(car);
}



static void CheckMileage(Dictionary<string, Car> cars, string car)
{
    if (cars[car].Mileage >= 100000)
    {
        cars.Remove(car);
        Console.WriteLine($"Time to sell the {car}!");
    }
}

class Car
{
    public Car()
    {
        
    }
    public Car(string brand, int mileage, int fuel)
    {
        Brand = brand;
        Mileage = mileage;
        Fuel = fuel;
    }
    public string Brand { get; set; }

    public int Mileage { get; set; }
    public int Fuel { get; set; }

    public void Drive(string[] input)
    {
        int distance = int.Parse(input[2]);
        int fuel = int.Parse(input[3]);
        if (Fuel >= fuel)
        {
            Mileage += distance;
            Fuel -= fuel;
            Console.WriteLine($"{Brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
    }

    public void Refuel(string[] input)
    {
        int fuel = int.Parse(input[2]);
        int capacity = 75;
        Fuel += fuel;
        if (Fuel > capacity)
        {
            fuel -= (Fuel - capacity);
            Fuel = capacity;
        }
        Console.WriteLine($"{Brand} refueled with {fuel} liters");
        
    }

    public void Revert(string[] input)
    {
        int kilometres = int.Parse(input[2]);
        Mileage -= kilometres;
        if (Mileage < 10_000)
        {
            Mileage = 10_000;
        }
        else
        {
            Console.WriteLine($"{Brand} mileage decreased by {kilometres} kilometers");
        }
    }

    public override string ToString()
    {
        return $"{Brand} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
    }
}