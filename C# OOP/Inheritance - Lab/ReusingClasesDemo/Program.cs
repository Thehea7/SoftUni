Student student = new Student();

student.Lastname = "asd";


public class Person
{
    private string name;
    protected int Age { get; set; }
    internal string Lastname { get; set; }

}

public class Student : Person
{
    public void Do()
    {
        string name = Lastname;
        int years = Age;
    }
}