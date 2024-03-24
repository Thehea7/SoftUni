

using _03.Stack;

_03.Stack.Stack<int> myStack = new _03.Stack.Stack<int>();

string commands;

while ((commands = Console.ReadLine()) != "END")
{
    string[] arguments = commands.Split(new  [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    switch (command)
    {
        case "Push":
            myStack.Push(arguments.Skip(1).Select(int.Parse).ToArray());
            break;
        case "Pop":
            try
            {
                Node<int> last = myStack.Pop();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No elements");
            }
            break;
    }

}

foreach (var number in myStack)
{
    Console.WriteLine(number);
}

foreach (var number in myStack)
{
    Console.WriteLine(number);
}

