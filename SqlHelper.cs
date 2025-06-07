using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using YourProjectName.Final.Models;

namespace YourProjectName.Final.Services
{
    public class SqlHelper
    {
        private readonly string _connectionString;

        public SqlHelper()
        {
            _connectionString = "Server=SHRAI\\SQLEXPRESS;Database=EntityNamePluralDatabase;Integrated Security=True;TrustServerCertificate=True;";
        }

        public void AddEntityName(EntityName entityName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO EntityNamePlural (Property1Name, Property2Name, Property3Name) VALUES (@Property1Name, @Property2Name, @Property3Name)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Property1Name", entityName.Property1Name);
                    command.Parameters.AddWithValue("@Property2Name", entityName.Property2Name);
                    command.Parameters.AddWithValue("@Property3Name", entityName.Property3Name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEntityName(EntityName entityName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE EntityNamePlural SET Property1Name = @Property1Name, Property2Name = @Property2Name, Property3Name = @Property3Name WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Property1Name", entityName.Property1Name);
                    command.Parameters.AddWithValue("@Property2Name", entityName.Property2Name);
                    command.Parameters.AddWithValue("@Property3Name", entityName.Property3Name);
                    command.Parameters.AddWithValue("@Id", entityName.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<EntityName> GetEntityNamePlural()
        {
            List<EntityName> entityNamePlural = new List<EntityName>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Property1Name, Property2Name, Property3Name FROM EntityNamePlural";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entityNamePlural.Add(new EntityName(
                                reader["Property1Name"].ToString(),
                                Convert.ToSingle(reader["Property2Name"]),
                                Convert.ToInt32(reader["Property3Name"])
                            )
                            {
                                Id = Convert.ToInt32(reader["Id"])
                            });
                        }
                    }
                }
            }

            return entityNamePlural;
        }

        public void DeleteEntityName(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM EntityNamePlural WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
