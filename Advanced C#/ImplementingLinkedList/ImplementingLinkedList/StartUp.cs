namespace ImplementingLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MyLinkedList test = new MyLinkedList();
            test.AddLast(5);
            test.AddLast(4);
            test.AddLast(3);
            test.AddLast(2);
            test.AddLast(1);

            
            
            Node node = test.Head;
            while (node != null)
            {
                Console.Write($"{node}, ");
                node = node.Next;
            }

            Console.WriteLine();
            Console.WriteLine($"Count: {test.Count}");

            node = test.Tail;

            while (node != null)
            {
                Console.Write($"{node}, ");
                node = node.Previous;
            }

            Console.WriteLine();
            Console.WriteLine($"Count: {test.Count}");

            Console.WriteLine(test.Head);
            Console.WriteLine(test.Tail);

            test.ForEach(Console.WriteLine);
            
            Console.WriteLine(string.Join(", ", test.ToArray()));
        }
    }
}