using SchoolManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DL
{
    public class CoursesDL
    {
        public static bool AddCourseIntoDatabase(Course course)
        {
            bool success = false;

            // Open connection to the database
            using (var connection = DBConnection.getInstance().getConnection())
            {
                connection.Open();

                try
                {
                    // Create command to insert the course data
                    var command = new SqlCommand(
                        "INSERT INTO courses (name, description, teacher_id, CreatedAt, UpdatedAt, Active) " +
                        "VALUES (@name, @description, @teacherId, @createdAt, @updatedAt, @active)", connection);

                    // Add parameters for each course property
                    command.Parameters.AddWithValue("@name", course.Name);
                    command.Parameters.AddWithValue("@description", course.Description);
                    command.Parameters.AddWithValue("@teacherId", course.TeacherId);
                    command.Parameters.AddWithValue("@createdAt", course.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", course.UpdatedAt);
                    command.Parameters.AddWithValue("@active", course.Active);

                    // Execute the command to insert the course data
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    connection.Close();
                }
            }

            return success;
        }
        public static DataTable getAllCourses()
        {

            string ConnectionStr = DBConnection.ConnectionStr;
            SqlConnection connection = new SqlConnection(ConnectionStr);

            connection.Open();

            try
            {
                // Execute SQL SELECT statement                
                SqlCommand cmd = new SqlCommand("Select * from courses;", connection);
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
