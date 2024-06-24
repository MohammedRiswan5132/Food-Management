using FoodmanagementSystem.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.DAL
{
    public class TableRepository
    {

        private string connectionString = "";
        public string GetConnectionString()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = configurationBuilder.Build();

            return configuration.GetConnectionString("MyDatabaseConnection");
        }

        public TableRepository()
        {
            this.connectionString = GetConnectionString();
        }
        public List<Tables> GetAllTables()
        {
            List<Tables> tables = new List<Tables>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Number,Capacity,Status FROM Tables";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Tables table = new Tables
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Number = Convert.ToInt32(reader["Number"]),
                        Capacity = Convert.ToInt32(reader["Capacity"]),
                        Status = reader["Status"].ToString()
                    };
                    tables.Add(table);
                }

                reader.Close();
            }

            return tables;
        }

        // Other CRUD operations for Tables
        public void UpdateTable(string id, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tables SET Status = @Status WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
