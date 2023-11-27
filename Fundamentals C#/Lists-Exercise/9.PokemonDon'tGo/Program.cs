namespace _9.PokemonDon_tGo
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    int value = input[0];
                    sum += value;
                    AdjustListElements(input, value);
                    input.RemoveAt(0);
                    int lastIndexValue = input[input.Count - 1];
                    input.Insert(0, lastIndexValue);
                }
                else if (index >= input.Count)
                {
                    int value = input[input.Count - 1];
                    sum += value;
                    AdjustListElements(input, value);
                    input.RemoveAt(input.Count -1);
                    int firstIndexValue = input[0];
                    input.Add(firstIndexValue);
                }
                else
                {
                    int value = input[index];
                    sum += value;
                    input.RemoveAt(index);
                    AdjustListElements(input, value);
                    
                }


            }

            Console.WriteLine(sum);
        }

        private static void AdjustListElements(List<int> input, int value)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= value)
                {
                    input[i] += value;
                }
                else
                {
                    input[i] -= value;
                }

            }
        }
    }
}