namespace Problem_1
{
    internal class Program
    {
        static void Main()
        {
            decimal experienceNeeded = decimal.Parse(Console.ReadLine());
            int entries = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entries; i++)
            {
                decimal currentExperience = decimal.Parse(Console.ReadLine());
                currentExperience = CheckCount(currentExperience, i);
                experienceNeeded -= currentExperience;
                if (experienceNeeded <= 0)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {experienceNeeded:f2} more needed.");
        }

        private static decimal CheckCount(decimal currentExperience, int i)
        {
            if (i % 15 == 0)
            {
                currentExperience *= 1.05m;
            }
            else if (i % 5 == 0)
            {
                currentExperience *= 0.9m;
            }
            else if (i % 3 == 0)
            {
                currentExperience *= 1.15m;
            }
            
            return currentExperience;
        }
    }
}