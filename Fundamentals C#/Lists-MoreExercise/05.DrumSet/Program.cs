namespace _05.DrumSet
{
    internal class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> currentState = drums.GetRange(0, drums.Count);

            string command = string.Empty;

            
            
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int damage = int.Parse(command);
                for (int i = 0; i < currentState.Count; i++)
                {
                    currentState[i] -= damage;
                    if (currentState[i] <= 0)
                    {
                        double price = drums[i] * 3;
                        if (balance >= price)
                        {
                            balance -= price;
                            currentState[i] = drums[i];
                        }
                        else
                        {
                            currentState[i] = 0;
                            drums[i] = 0;

                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", currentState.FindAll(x => x > 0)));
            Console.WriteLine($"Gabsy has {balance:f2}lv.");
            
        }
    }
}