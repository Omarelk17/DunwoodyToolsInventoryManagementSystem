using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using BCrypt.Net;
using Microsoft.Data.SqlClient;
using DunwoodyToolsInventoryManagementSystem.Models;

namespace DunwoodyToolsInventoryManagementSystem.Repository
{
    public class LoginRepository
    {
        private readonly string _connectionString;

        public LoginRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["InventoryToolsDb"].ConnectionString;
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT PasswordHash, Salt, Role FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    string storedSalt = reader["Salt"].ToString();
                    string role = reader["Role"].ToString();
                    // Set the global UserRole
                    GlobalVariables.UserRole = role;

                    // Combine the stored salt with the provided password and hash it
                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
