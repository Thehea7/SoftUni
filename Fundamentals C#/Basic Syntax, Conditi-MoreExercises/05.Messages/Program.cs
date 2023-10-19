char y = (char)97;
int x = 0;
int inputs = int.Parse(Console.ReadLine());
int counter = 1;
string input = Console.ReadLine();
int index = 0;
string output = "";
while (counter <= inputs)
{
    int digits = input.Length;
    int mainDigit = int.Parse(input[0].ToString());
    if (mainDigit == 0)
    {
        output += " ";
        input = Console.ReadLine();
        counter++;
        continue;
    }
    else
    {
        int offset = 0;

        if (mainDigit >= 2 && mainDigit <= 7)
        {
            offset = (mainDigit - 2) * 3;
        }
        else offset = (mainDigit - 2) * 3 + 1;
        index = offset + input.Length -1;

    }
    if (index == 0) x = 97;
    else if (index == 1) x = 98;
    else if (index == 2) x = 99;
    else if (index == 3) x = 100;
    else if (index == 4) x = 101;
    else if (index == 5) x = 102;
    else if (index == 6) x = 103;
    else if (index == 7) x = 104;
    else if (index == 8) x = 105;
    else if (index == 9) x = 106;
    else if (index == 10) x = 107;
    else if (index == 11) x = 108;
    else if (index == 12) x = 109;
    else if (index == 13) x = 110;
    else if (index == 14) x = 111;
    else if (index == 15) x = 112;
    else if (index == 16) x = 113;
    else if (index == 17) x = 114;
    else if (index == 18) x = 115;
    else if (index == 19) x = 116;
    else if (index == 20) x = 117;
    else if (index == 21) x = 118;
    else if (index == 22) x = 119;
    else if (index == 23) x = 120;
    else if (index == 24) x = 121;
    else if (index == 25) x = 122;

    output += (char)x;

    
    input = Console.ReadLine();
    counter++;
}


Console.WriteLine(output);