// IMPORTANT: Replace YourProjectName with your actual project's root namespace
using YourProjectName.Final.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

// IMPORTANT: Replace YourProjectName with your actual project's root namespace
namespace YourProjectName.Final.Services
{
    public class SqlHelper
    {
        private readonly string _connectionString;

        public SqlHelper()
        {
            // IMPORTANT: Change {EntityNamePlural}Database to your actual database name (e.g., CarDatabase, CatsDatabase)
            _connectionString = "Server=SHRAI\\SQLEXPRESS;Database={EntityNamePlural}Database;Integrated Security=True;TrustServerCertificate=True;";
        }

        // IMPORTANT: Change method name and parameter type
        public void Add{EntityName}({EntityName} {EntityName.ToLower()})
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // IMPORTANT: Change table name and column names to match your SQL table
                string sql = "INSERT INTO {EntityNamePlural} ({Property1Name}, {Property2Name}, {Property3Name}) VALUES (@{Property1Name}, @{Property2Name}, @{Property3Name})";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // IMPORTANT: Add parameters for your new properties
                    command.Parameters.AddWithValue("@{Property1Name}", {EntityName.ToLower()}.{Property1Name});
                    command.Parameters.AddWithValue("@{Property2Name}", {EntityName.ToLower()}.{Property2Name});
                    command.Parameters.AddWithValue("@{Property3Name}", {EntityName.ToLower()}.{Property3Name});
                    command.ExecuteNonQuery();
                }
            }
        }

        // IMPORTANT: Change method name and parameter type
        public void Update{EntityName}({EntityName} {EntityName.ToLower()})
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // IMPORTANT: Change table name and column names to match your SQL table
                string sql = "UPDATE {EntityNamePlural} SET {Property1Name} = @{Property1Name}, {Property2Name} = @{Property2Name}, {Property3Name} = @{Property3Name} WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // IMPORTANT: Add parameters for your new properties
                    command.Parameters.AddWithValue("@{Property1Name}", {EntityName.ToLower()}.{Property1Name});
                    command.Parameters.AddWithValue("@{Property2Name}", {EntityName.ToLower()}.{Property2Name});
                    command.Parameters.AddWithValue("@{Property3Name}", {EntityName.ToLower()}.{Property3Name});
                    command.Parameters.AddWithValue("@Id", {EntityName.ToLower()}.Id); // Important: Update by ID
                    command.ExecuteNonQuery();
                }
            }
        }

        // IMPORTANT: Change method name and return type
        public List<{EntityName}> Get{EntityNamePlural}()
        {
            List<{EntityName}> {EntityNamePlural.ToLower()} = new List<{EntityName}>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // IMPORTANT: Change table name and column names to match your SQL table
                string sql = "SELECT Id, {Property1Name}, {Property2Name}, {Property3Name} FROM {EntityNamePlural}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {EntityNamePlural.ToLower()}.Add(new {EntityName}(
                                // IMPORTANT: Update property assignments and conversion types
                                {Property1Name.ToLower()}: reader["{Property1Name}"].ToString(),
                                {Property2Name.ToLower()}: Convert.{Property2Type == "float" ? "ToSingle" : Property2Type == "int" ? "ToInt32" : "ToString"}(reader["{Property2Name}"]), // Auto-adjusts conversion
                                {Property3Name.ToLower()}: Convert.{Property3Type == "float" ? "ToSingle" : Property3Type == "int" ? "ToInt32" : "ToString"}(reader["{Property3Name}"])  // Auto-adjusts conversion
                            )
                            {
                                Id = Convert.ToInt32(reader["Id"])
                            });
                        }
                    }
                }
            }

            return {EntityNamePlural.ToLower()};
        }

        // IMPORTANT: Change method name
        public void Delete{EntityName}(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // IMPORTANT: Change table name
                string sql = "DELETE FROM {EntityNamePlural} WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
