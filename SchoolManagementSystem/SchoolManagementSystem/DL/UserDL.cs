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
            SqlConnection connection = DbConnection.getInstance().getConnection();

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

        public static bool LoginUser(string email, string password)
        {
            // Open a connection to the database
            SqlConnection connection = DbConnection.getInstance().getConnection();
            connection.Open();
            

            // Create and execute the SQL SELECT statement
            using (SqlCommand command = new SqlCommand("SELECT * FROM users WHERE email = @email AND password = @password", connection))
            {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = command.ExecuteReader();

                // Check if any user is found
                if (reader.HasRows)
                {
                    // Login successful
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    // Login failed
                    reader.Close();
                    connection.Close(); 
                    return false;
                }
            }
        }
        public static DataTable getAllUserss()
        {
            List<Teacher> teachers = new List<Teacher>();

            SqlConnection connection = DbConnection.getInstance().getConnection();

            connection.Open();

            try
            {


                // Execute SQL SELECT statement

                SqlCommand cmd = new SqlCommand("Select * from users;", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
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
