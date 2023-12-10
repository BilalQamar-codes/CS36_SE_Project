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
                        "INSERT INTO courses (name, description, teacher_id,class_id, CreatedAt, UpdatedAt, Active) " +
                        "VALUES (@name, @description, @teacherId,@classId, @createdAt, @updatedAt, @active)", connection);

                    // Add parameters for each course property
                    command.Parameters.AddWithValue("@name", course.Name);
                    command.Parameters.AddWithValue("@description", course.Description);
                    command.Parameters.AddWithValue("@teacherId", course.TeacherId);
                    command.Parameters.AddWithValue("@classId", course.ClassId);
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
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                // Open the connection
                connection.Open();

                try
                {
                    // Execute SQL SELECT statement
                    string sql = @"
                                SELECT
                                    c.course_id,
                                    c.name AS course_name,
                                    t.first_name + ' ' + t.last_name AS teacher_name,
                                    c.description,
                                    c.teacher_id,
                                    c.created_at,
                                    c.updated_at,
                                    c.active
                                FROM courses AS c
                                INNER JOIN teachers AS t ON c.teacher_id = t.teacher_id;
                                ";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Close the connection
                    connection.Close();

                    return dt;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }


        }
        public static int getTotalCourses()
        {
            using (var connection = new SqlConnection(DBConnection.ConnectionStr))
            {
                connection.Open();

                using (var command = new SqlCommand($"SELECT COUNT(*) FROM courses", connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }


    }
}
