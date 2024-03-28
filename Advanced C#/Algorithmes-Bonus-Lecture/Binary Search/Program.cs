

using System.Linq.Expressions;


int[] sortedArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int element = int.Parse(Console.ReadLine());

Console.WriteLine(GetIndex(sortedArray, element));

static int GetIndex(int[] sortedArray, int element)
{
    int index = FindIndex(sortedArray, element, 0, sortedArray.Length - 1);
    return index;
}
static int FindIndex(int[] array, int element, int startIndex, int endIndex)
{
    int index = -1;


    //Random random = new Random();
    //int randomIndex = random.Next(startIndex, endIndex);
    int randomIndex = (endIndex - startIndex) / 2 + startIndex;

    if (array[randomIndex] == element)
    {
        index = randomIndex;
    }

    if (array[randomIndex] < element && endIndex - randomIndex > 0)
    {
        index = FindIndex(array, element, randomIndex+1, endIndex);
    }

    if (array[randomIndex] > element && randomIndex - startIndex >0 )
    {
        index = FindIndex(array, element, startIndex, randomIndex-1);
    }

    

    return index;
}