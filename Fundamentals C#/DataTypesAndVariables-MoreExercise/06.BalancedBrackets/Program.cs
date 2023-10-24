int nLines = int.Parse(Console.ReadLine());
bool isBalanced = true;
for (int i = 0; i < nLines; i++)
{
    string input = Console.ReadLine();
    if (input[0] == '(' && !isBalanced) break;
    if (input[0] == '(')
    {
        isBalanced = false;
    }
    
    if (input[0] == ')' && !isBalanced) isBalanced = true;
    else if (input[0] == ')' && isBalanced)
    {
        isBalanced = false;
        break;
    }

}

if (isBalanced) Console.WriteLine("BALANCED");
else Console.WriteLine("UNBALANCED");