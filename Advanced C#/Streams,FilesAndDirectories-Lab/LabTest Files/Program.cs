namespace LabTest_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"..\..\..\input.txt";

            //string text = File.ReadAllText(Filepath);
            //Console.WriteLine(text);


            string[] textArray = File.ReadAllLines(Filepath);
            Console.WriteLine(textArray[0]);
        }
    }
}