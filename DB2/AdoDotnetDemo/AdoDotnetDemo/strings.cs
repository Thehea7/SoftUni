using Microsoft.Data.SqlClient;

namespace FromLaptop
{
    public  class Vryzka
    {
        //servername   = DESKTOP-IKUABEV\SQLSOFTUNI
        // Database = MinionsDB
        // const string ConnectionString = "Server=DESKTOP-IKUABEV\\SQLSOFTUNI;Database=MinionsDB";
        private static SqlConnection connection;
        const  string ConnectionString = "Server=tcp:softuni.database.windows.net,1433;Initial Catalog=C#DB;Persist Security Info=False;User ID=amatsev;Password=A000216a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

       public static string Azure()
        {
            return ConnectionString;
        }

        //static void Main(string[] args)
        //{
        //    using SqlConnection connection = new SqlConnection(ConnectionString);
        //    connection.Open();

        //    Console.WriteLine("All good");
            
        //}
    }
}