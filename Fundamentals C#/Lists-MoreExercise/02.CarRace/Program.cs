namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> car1 = input.GetRange(0, (input.Count - 1) / 2);
            List<int> car2 = input.GetRange((input.Count + 1) / 2, (input.Count - 1) / 2);
            car2.Reverse();


            double topSpeed = Math.Min(Speed(car1), Speed(car2));
            string fasterCar = string.Empty;
            if (Speed(car1) < Speed(car2))
            {
                fasterCar = "left";
            }
            else if(Speed(car2) < Speed(car1)) 
            {
                fasterCar = "right";
            }


            Console.WriteLine($"The winner is {fasterCar} with total time: {topSpeed}");

        }

        private static double Speed(List<int> input)
        {
            double speed = 0;
            for (int i = 0; i < input.Count; i++)
            {
                speed += input[i];
                if (input[i] == 0)
                {
                    speed *= 0.8;
                }
            }

            return speed;
        }
    }
}