
MySolution();

void MySolution()
{
    int[] array = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();


    Array.Sort(array,new Comparator());

    Console.WriteLine(string.Join(" ", array));
}


public class Comparator : IComparer<int>
{

    

    public int Compare(int x, int y)
    {
        int compare = Math.Abs(x % 2).CompareTo(Math.Abs(y % 2));
        if (compare == 0)
        {
            compare = x.CompareTo(y);
        }

        return compare;
    }
}

