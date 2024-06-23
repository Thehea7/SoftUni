using System.Data;
using Azure;
using Microsoft.Data.SqlClient;

namespace AdoNetExercises
{
    internal class Program
    {
        // 1. Connect ion string
        const string connectionString = @"Server=DESKTOP-IKUABEV\SQLSOFTUNI;Database=MinionsDB;Integrated Security = True;Trusted_Connection=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        static async Task Main(string[] args)
        {
          // 2. SQL Connection
            // 3. CREATE COMMAND
            // 4. DATA Reader
            connection = new SqlConnection(connectionString);
            connection.Open();

           // GetVillainsCommand();
          await GetOrderedMinionsByVillainID(7);
        }

        private static async Task GetOrderedMinionsByVillainID(int id)
        {
          using  SqlCommand command = new SqlCommand(Querie.GetVillainByID, connection);
          command.Parameters.AddWithValue("Id", id);
          var result = await command.ExecuteScalarAsync();
          if (result == null)
          {
              await Console.Out.WriteLineAsync($"No villain with ID {id} exist in the database.");
          }
          else
          {
              await Console.Out.WriteLineAsync($"Villain: {result}");
              using SqlCommand commandGetMinionData = new SqlCommand(Querie.GetOrderedMinionsByVillainID, connection);
              commandGetMinionData.Parameters.AddWithValue("@Id", id);
              var minionsReader = await commandGetMinionData.ExecuteReaderAsync();

              while (await minionsReader.ReadAsync())
              {
                  await Console.Out.WriteLineAsync(
                      $"{minionsReader["RowNum"]}. {minionsReader["Name"]} {minionsReader["Age"]}");
              }
          }
        }

        private static void GetVillainsCommand()
        {
            using SqlCommand GetVillainsCommand = new SqlCommand(Querie.GetVillainsWithNumberOfMinions, connection);

            using SqlDataReader sqlDataReader = GetVillainsCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader["Name"]} - {sqlDataReader["TotalMinions"]}");
            }
        }

    }
}