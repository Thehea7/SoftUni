using Microsoft.Data.SqlClient;

namespace AdoNetExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //servername   = DESKTOP-IKUABEV\SQLSOFTUNI
            // Database = MinionsDB
            const string _connectionString = @"Server=DESKTOP-IKUABEV\SQLSOFTUNI;Database=MinionsDB"
            string connectionString = "Server=DESKTOP-IKUABEV\\SQLSOFTUNI;Database=SoftUni;Trusted_Connection=True;TrustServerCertificate=True";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT FirstName, LastName, Salary FROM Employees WHERE Salary > @salaryParam";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@salaryParam", 10000);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read()) 
            {
                string firstName = dataReader["FirstName"].ToString();
                string lastName = dataReader["LastName"].ToString();
                string salary = dataReader["Salary"].ToString();


                Console.WriteLine($"{firstName} {lastName}, receives {salary:C}.");
            }
        }
    }
}