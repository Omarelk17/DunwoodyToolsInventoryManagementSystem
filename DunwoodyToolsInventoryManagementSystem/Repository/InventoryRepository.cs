using DunwoodyToolsInventoryManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyToolsInventoryManagementSystem.Repository
{
    public class InventoryRepository
    {
        private readonly string _connectionString;

        public InventoryRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["InventoryToolsDb"].ConnectionString;
        }

        // CREATE
        public int? AddInventoryItem(Inventory item)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Query to insert the record and return the new InventoryId
                string query = @"INSERT INTO Inventory (InventoryName, CategoryName, InventoryPicture, Status, Description, CreatedAt) 
                         VALUES (@InventoryName, @CategoryName, @InventoryPicture, @Status, @Description, @CreatedAt);
                         SELECT SCOPE_IDENTITY();";  // This will return the last inserted ID

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@InventoryName", item.InventoryName);
                    cmd.Parameters.AddWithValue("@CategoryName", item.CategoryName);
                    cmd.Parameters.AddWithValue("@InventoryPicture", item.InventoryPicture ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", item.Status);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@CreatedAt", item.CreatedAt);

                    conn.Open();

                    // Execute the query and get the new ID
                    object result = cmd.ExecuteScalar();

                    // Convert result to int and return; return null if insert fails
                    return result != null ? Convert.ToInt32(result) : (int?)null;
                }
            }
        }
        // READ
        public List<Inventory> GetAllInventoryItems(string search = null)
        {
            List<Inventory> items = new List<Inventory>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Base query to fetch inventory items
                string query = "SELECT InventoryId, InventoryName, CategoryName, Status, CreatedAt " +
                               "FROM Inventory ";

                // Check if a search term is provided
                if (!string.IsNullOrWhiteSpace(search))
                {
                    // If a search term is provided, append a WHERE clause
                    query += "WHERE (InventoryId LIKE @Search OR InventoryName LIKE @Search OR CategoryName LIKE @Search)";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use '%' wildcard to allow for partial matches
                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new Inventory
                            {
                                InventoryId = Convert.ToInt32(reader["InventoryId"]),
                                InventoryName = reader["InventoryName"].ToString(),
                                CategoryName = reader["CategoryName"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            });
                        }
                    }
                }
            }

            return items;
        }


        // READ Single Record
        public Inventory GetInventoryItemById(int inventoryId)
        {
            Inventory item = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT InventoryId, InventoryName, CategoryName, InventoryPicture, Status, Description, CreatedAt " +
                               "FROM Inventory WHERE InventoryId = @InventoryId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InventoryId", inventoryId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = new Inventory
                            {
                                InventoryId = Convert.ToInt32(reader["InventoryId"]),
                                InventoryName = reader["InventoryName"].ToString(),
                                CategoryName = reader["CategoryName"].ToString(),
                                InventoryPicture = reader["InventoryPicture"] as byte[],
                                Status = reader["Status"].ToString(),
                                Description = reader["Description"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };
                        }
                    }
                }
            }

            return item;
        }

        // UPDATE
        public bool UpdateInventoryItem(Inventory item)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Inventory SET InventoryName = @InventoryName, CategoryName = @CategoryName, " +
                               "InventoryPicture = @InventoryPicture, Status = @Status, Description = @Description " +
                               "WHERE InventoryId = @InventoryId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InventoryId", item.InventoryId);
                    cmd.Parameters.AddWithValue("@InventoryName", item.InventoryName);
                    cmd.Parameters.AddWithValue("@CategoryName", item.CategoryName);
                    cmd.Parameters.AddWithValue("@InventoryPicture", item.InventoryPicture ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", item.Status);
                    cmd.Parameters.AddWithValue("@Description", item.Description);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE
        public bool DeleteInventoryItem(int inventoryId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Inventory WHERE InventoryId = @InventoryId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InventoryId", inventoryId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
