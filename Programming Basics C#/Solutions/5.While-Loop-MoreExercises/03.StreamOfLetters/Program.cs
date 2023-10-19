


string input = Console.ReadLine();
string text = string.Empty;
string currentText = string.Empty;
bool isEnglish = false;
int nCounter = 0;
int cCounter = 0;
int oCounter = 0;
int counter = 0;

while (input != "End")
{
    if ((input[0] >= 'a' &&  input[0] <= 'z') || (input[0] >= 'A' && input[0] <= 'Z'))
    {
        isEnglish = true;
    }
    else
    {
        input = Console.ReadLine();
        continue;
    }
 
    if (input == "n" &&  nCounter == 0)
    {
        nCounter++;
        counter++;
    }
    else if (input == "c" && cCounter == 0)
    {
        cCounter++;
        counter++;
        
    }
    else if (input == "o" && oCounter == 0)
    {
        oCounter++;
        counter++;
    }
     else
    {
        currentText += input;
    }

     if (counter == 3)
    {
        currentText += " ";
        text += currentText;
        currentText = string.Empty;
        counter = 0;
        cCounter = 0;
        oCounter = 0;
        nCounter = 0;
    }
     isEnglish = false;
    input = Console.ReadLine();
}

Console.WriteLine(text);

