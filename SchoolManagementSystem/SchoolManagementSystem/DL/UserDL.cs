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
        public static void addUserIntoDatabase(User user)
        {
            SqlConnection connection = DbConnection.getInstance().getConnection();

            // Connect to the database.
            connection.Open();

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
                using (SqlCommand command = new SqlCommand(@"INSERT INTO users (username, email, password, role, CreatedAt, UpdatedAt, Active) VALUES (@username, @email, @password, @role, @createdAt, @updatedAt, @active)", connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@createdAt", user.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", user.UpdatedAt);
                    command.Parameters.AddWithValue("@active", user.Active);

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                // Always close the connection.
                connection.Close();
            }
        }


    }
}
