

string bookToLookFor = Console.ReadLine();
string book = Console.ReadLine();
int booksChecked = 0;


while (book != bookToLookFor)
{
    
    if (book == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {booksChecked} books.");
        break;
    }
    booksChecked++;
    book = Console.ReadLine();

}
if (book == bookToLookFor)
Console.WriteLine($"You checked {booksChecked} books and found it.");