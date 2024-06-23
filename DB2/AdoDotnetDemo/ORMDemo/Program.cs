namespace ORMDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDBContext();

            var result = from emmployee
                         in context.Employees
                         where emmployee.FirstName == "Pesho"
                         select emmployee;  // Classic LINQ

            var result1 = context.Employees
                .Where(e => e.FirstName == "Pesho"); // Nowdays Way - with extension methods
        }
    }
}
