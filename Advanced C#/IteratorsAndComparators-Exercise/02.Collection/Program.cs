using _01.ListyIterator;


ListyIterator<string> listy = new ListyIterator<string>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList());


string command;

while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Move":
            Console.WriteLine(listy.Move());
            break;
        case "HasNext":
            Console.WriteLine(listy.HasNext());
            break;
        case "Print":
            try
            {
                listy.Print();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Operation!");
            }
            break;
        case "PrintAll":
            foreach (var element in listy)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            break;
    }


}


