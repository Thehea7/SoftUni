namespace ImplementingStackAndQueue
{
    internal class Program
    {
        ///
        static void Main()
        {
            MyList list = new MyList();
            list.Add(4);
            list.Add(5);
            list.Add(6);

            int a = list[2];

            Console.WriteLine(a);
            Console.WriteLine(list.Count);


            Console.WriteLine(list);
            int b = list.RemoveAt(0);
            Console.WriteLine($" Count: {list.Count}");
            Console.WriteLine(list);
            int c = list.RemoveAt(0);
            Console.WriteLine($" Count: {list.Count}");
            Console.WriteLine(list);
            list.Insert(0, 8);
            Console.WriteLine(list);
            Console.WriteLine(list.Count);
            list.Insert(1, 158);
            Console.WriteLine(list);
            Console.WriteLine(list.Count);
            list.Swap(0, 2);
            Console.WriteLine(list);
            list.Insert(3, 16);
            Console.WriteLine(list);
            MyList list2 = new MyList(5); 

            Console.WriteLine(list.Contains(157));
        }
    }
}