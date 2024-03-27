int[] array = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Console.WriteLine(GetSum(array, 0));
 static int GetSum(int[] array, int index)
 {
     if (index == array.Length)
     {
         return 0;
     }
     int result = array[index] + GetSum(array, index + 1);

     return result;
 }