//var numbers = new[] { 1, 5, 0, 0, 3, 9,125 };
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

SortArray(numbers);

Console.WriteLine(string.Join(" ", numbers));

static void SortArray(int[] numbers)
{
    QuickSort(numbers, 0, numbers.Length - 1);
}

static void QuickSort(int[] numbers, int begining, int finish)
{
    int startIndex = begining;
    int endIndex = finish;

    var pivot = numbers[(begining + finish) / 2] ;

    while (startIndex <= endIndex)
    {
        while (numbers[startIndex] < pivot)
        {
            startIndex++;
        }

        while (numbers[endIndex] > pivot)
        {
            endIndex--;
        }

        if (startIndex <= endIndex)
        {
            (numbers[startIndex], numbers[endIndex]) = (numbers[endIndex], numbers[startIndex]);
            startIndex++;
            endIndex--;
        }
    }

    if (begining < endIndex)
    {
        QuickSort(numbers, begining, endIndex);
    }

    if (startIndex < finish)
    {
        QuickSort(numbers, startIndex, finish);
    }
}