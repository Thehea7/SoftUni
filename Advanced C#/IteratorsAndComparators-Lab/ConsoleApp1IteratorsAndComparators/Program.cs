//using System.Text.Json;
//using System.Text.Json.Nodes;
//using IteratorsAndComparators;

//Book bookOne = new Book("Animal Farm", 2003, "George Orwell"); 
//Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
//Book bookThree = new Book("The Documents in the Case", 1930);

//Library libraryOne = new Library();
//Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

//foreach (var book in libraryTwo)
//{
//    Console.WriteLine(book);
//}

//using (JsonWriterOptions)
//{

//}


University softUni = new University("SoftUni", 7, "1");
University MIT = new University("MIT", 7, "1");

Console.WriteLine(softUni.CompareTo(MIT));

class University : IComparable<University>
{
    public string Name { get; set; }
    public List<string> Students { get; set; }
    public double AverageScore { get; set; }

    public University(string name, double averageScore, params string[] students)
    {
        Name = name;
        AverageScore = averageScore;
        Students = new List<string>(students);
    }

    public int CompareTo(University? other)
    {
        if (AverageScore.CompareTo(other.AverageScore) == 0)
        {
            return Students.Count.CompareTo(other.Students.Count);
        }
        return AverageScore.CompareTo(other.AverageScore);
    }
}