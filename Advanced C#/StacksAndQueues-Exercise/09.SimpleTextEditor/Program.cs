namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main()
        {
            Stack<char> text = new Stack<char>();
            Stack<string> undo = new Stack<string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);
                if (command == 1)
                {

                    string lastState = string.Join("", text);
                    undo.Push(lastState);
                    for (int j = 0; j < input[1].Length; j++)
                    {

                        text.Push(input[1][j]);
                    }
                }
                else if (command == 2)
                {
                    string lastState = string.Join("", text);
                    undo.Push(lastState);
                    for (int j = 0; j < int.Parse(input[1]); j++)
                    {
                        text.Pop();
                    }
                }
                else if(command == 3)
                {
                    int index = int.Parse(input[1]) -1;
                    string output = string.Join("", text.Reverse());
                    
                    //output = output.Reverse().ToString();
                    Console.WriteLine(output[index]);

                }
                else if(command == 4)
                {
                    string lastState = undo.Pop();
                    text = new Stack<char>(lastState.ToCharArray().Reverse());
                }
            }
        }
    }
}
/*
8 
1 abc
3 3
2 3
1 xy
3 2
4
4 
3 1
   
 */