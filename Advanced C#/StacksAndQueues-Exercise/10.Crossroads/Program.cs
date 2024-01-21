namespace _10.Crossroads
{
    internal class Program
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;
            bool crash = false;

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                int currentTime = greenLight;

                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    while (currentTime > 0 && cars.Any())
                    {
                        string currentCar = cars.Dequeue();
                        if (currentTime + freeWindow < currentCar.Length)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[freeWindow + currentTime]}.");
                            return;
                        }
                        currentTime -= currentCar.Length;
                        carsPassed ++;
                    }
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");


        }
    }
}