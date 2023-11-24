namespace _2.Gauss_Trick
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();

            for (int i = 0, j = input.Count -1; i < input.Count && j >=i; i++, j --)
            {
                if (j == i)
                {
                    output.Add(input[i]);
                    break;
                }

                output.Add(input[i] + input[j]);    
            }

            Console.WriteLine(string.Join(" ", output));
            
        }
    }
}

// Solution 2
//
//List<int> input = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToList();
//List<int> output = new List<int>();
//for (int i = 0; i <= input.Count/2 - 1; i++)
//{
//    output.Add(input[i] + input[input.Count - 1 - i]); 
//}

//if (input.Count % 2 != 0)
//{
//    output.Add(input[input.Count / 2]);
//}

//Console.WriteLine(string.Join(" ", output));