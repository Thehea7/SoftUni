using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.StackOfStrings;

namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("args");

            Console.WriteLine(stack.IsEmpty());
            string[] alabala = new string[] { "asd", "asd", "ghdf" };

            stack.AddRange(alabala);
            Console.WriteLine(stack.IsEmpty());
            while (stack.IsEmpty() == false)
            {
                Console.Write(stack.Pop() + "," + " ");
            }

            Console.WriteLine(stack.IsEmpty());

        }
    }
}
