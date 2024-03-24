

using _03.Stack;

NodeSolution();

void NodeSolution()
{
    _03.Stack.Stack<int> myStack = new _03.Stack.Stack<int>();

    int[] arguments = Console.ReadLine()
        .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    myStack.Push(arguments);

    Console.WriteLine(string.Join(", ", myStack));
}

