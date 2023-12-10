using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.BL;

namespace SchoolManagementSystem.DL
{
    public class ClassDL
    {
        public static DataTable getAllClasses()
        {

            string ConnectionStr = DBConnection.ConnectionStr;
            SqlConnection connection = new SqlConnection(ConnectionStr);

            connection.Open();

            try
            {
                // Execute SQL SELECT statement                
                SqlCommand cmd = new SqlCommand("Select * from classes;", connection);
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
        public static bool AddClassIntoDatabase(Class classObject)
        {
            bool success = false;

            using (var connection = new SqlConnection(DBConnection.ConnectionStr))
            {
                connection.Open();

                try
                {
                    var command = new SqlCommand(
                        "INSERT INTO classes (name, level, CreatedAt, UpdatedAt, Active) " +
                        "VALUES (@name, @level, @createdAt, @updatedAt, @active)", connection);

                    command.Parameters.AddWithValue("@name", classObject.Name);
                    command.Parameters.AddWithValue("@level", classObject.Level);
                    command.Parameters.AddWithValue("@createdAt", classObject.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", classObject.UpdatedAt);
                    command.Parameters.AddWithValue("@active", classObject.Active);

                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    // ...
                }
                finally
                {
                    connection.Close();
                }
            }

            return success;
        }

    }
}
