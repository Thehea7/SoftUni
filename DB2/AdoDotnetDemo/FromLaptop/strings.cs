using Microsoft.Data.SqlClient;

namespace FromLaptop
{
    public static class ConnectionStrings
    {
        //servername   = DESKTOP-IKUABEV\SQLSOFTUNI
        // Database = MinionsDB
       // const string ConnectionString = "Server=DESKTOP-IKUABEV\\SQLSOFTUNI;Database=MinionsDB";
        const string ConnectionString = "Server=tcp:softuni.database.windows.net,1433;Initial Catalog=C#DB;Persist Security Info=False;User ID=amatsev;Password=A000216a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            Console.WriteLine("All good");
            
        }
    }
}