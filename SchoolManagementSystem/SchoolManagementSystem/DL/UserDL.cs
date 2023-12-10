using SchoolManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace SchoolManagementSystem.DL
{
    public  class UserDL
    {
        public static int addUserIntoDatabase(User user)
        {
            string ConnectionStr = DBConnection.ConnectionStr;
            SqlConnection connection = new SqlConnection(ConnectionStr);
            // Connect to the database.
            connection.Open();

            int newUserId = 0;

            try
            {
                // Check if user with the same email already exists.
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", user.Email);
                    int existingUsers = (int)command.ExecuteScalar();

                    if (existingUsers > 0)
                    {
                        throw new Exception("User with the same email already exists.");
                    }
                }

                // Continue with the insertion if the email is unique.
                using (SqlCommand command = new SqlCommand(@"INSERT INTO users (username, email, password, role, CreatedAt, UpdatedAt, Active) VALUES (@username, @email, @password, @role, @createdAt, @updatedAt, @active); SELECT SCOPE_IDENTITY();", connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@createdAt", user.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", user.UpdatedAt);
                    command.Parameters.AddWithValue("@active", user.Active);
                    command.ExecuteNonQuery();
                    // Get the generated user ID using SCOPE_IDENTITY
                }
                using (SqlCommand command = new SqlCommand("SELECT MAX(User_Id) FROM users", connection))
                {
                    object maxIdObject = command.ExecuteScalar();

                    if (maxIdObject != null)
                    {
                        newUserId = (int)maxIdObject;
                    }
                }
            }
            catch(Exception ex)
            {
                connection.Close();
                LogsDL.LogException(ex);
                throw new Exception("Error Adding User in Database"+ex.Message );
            }
            finally
            {
                // Always close the connection.
                connection.Close();
            }

            return newUserId;
        }

        public static User LoginUser(string email, string password)
        {
            User user = null;

            try
            {
                // Open a connection to the database
                string connectionString = DBConnection.ConnectionStr;
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create and execute the SQL SELECT statement
                    using (var command = new SqlCommand("SELECT * FROM users WHERE email = @email AND password = @password", connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        // Read the user data
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Get user data from the first row
                                while (reader.Read())
                                {
                                    user = new User();
                                    user.UserId = reader.GetInt32(0);
                                    user.Username = reader.GetString(1);
                                    user.Email = reader.GetString(2);
                                    user.Password = reader.GetString(3);
                                    user.Role = reader.GetString(4);
                                    user.CreatedAt = reader.GetDateTime(5);
                                    user.UpdatedAt = reader.GetDateTime(6);
                                    user.Active = reader.GetBoolean(7);
                                    
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("Error during login: " + ex.Message);
            }

            return user;
        }

        public static DataTable getAllUserss()
        {

            string ConnectionStr = DBConnection.ConnectionStr;
            SqlConnection connection = new SqlConnection(ConnectionStr);

            try
            {
                // Execute SQL SELECT statement
                SqlCommand cmd = new SqlCommand("Select * from users;", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                return dt;
                // Close connection and reader

            }
            finally
            {
                connection.Close();
            }


        }



    }
}
