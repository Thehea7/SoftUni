namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> mixedList = new List<int>();

            int itterations = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < itterations; i++)
            {
                mixedList.Add(list1[i]);
                mixedList.Add(list2[list2.Count -1 -i]);
            }
            List<int> range = new List<int>();
            if (list1.Count > list2.Count)
            {
                range = list1;
                range.RemoveRange(0, itterations);
            }
            else
            {
                range = list2;
                range.RemoveRange(2, itterations);
            }
            range.Sort();
            
            List<int> output = mixedList.FindAll(x => x > range[0] && x < range[1]);
           output.Sort();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}