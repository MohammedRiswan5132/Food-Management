using FoodmanagementSystem.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FoodmanagementSystem.DAL
{
    public class FoodItemRepository
    {
        private string connectionString = "";
        public string GetConnectionString()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = configurationBuilder.Build();

            return configuration.GetConnectionString("MyDatabaseConnection");
        }

        public FoodItemRepository()
        {
            this.connectionString = GetConnectionString();
        }
        public List<FoodItem> GetAllFoodItem()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FoodName, Price FROM FoodItem";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                
            }

            return foodItems;
        }

        
            }
        }
   
