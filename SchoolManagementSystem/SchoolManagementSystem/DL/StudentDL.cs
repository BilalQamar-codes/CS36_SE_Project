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
    public class StudentDL
    {
        public static bool AddStudentIntoDatabase(Student student)
        {
            bool success = false;

            // Open connection to the database
            using (var connection = DBConnection.getInstance().getConnection())
            {
                connection.Open();

                try
                {
                    // Create a command to insert the student data
                    var command = new SqlCommand(
                        "INSERT INTO students (first_name, last_name, date_of_birth, gender, address, phone_number, email, CreatedAt, UpdatedAt, Active) " +
                        "VALUES (@firstName, @lastName, @dateOfBirth, @gender, @address, @phoneNumber, @email, @createdAt, @updatedAt, @active)",
                        connection);

                    // Add parameters for each student property
                    command.Parameters.AddWithValue("@firstName", student.FirstName);
                    command.Parameters.AddWithValue("@lastName", student.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", student.Gender);
                    command.Parameters.AddWithValue("@address", student.Address);
                    command.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                    command.Parameters.AddWithValue("@email", student.Email);
                    command.Parameters.AddWithValue("@createdAt", student.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", student.UpdatedAt);
                    command.Parameters.AddWithValue("@active", student.Active);

                    // Execute the command to insert the student data
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding Student into Database! "+ ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return success;
        }
        public static DataTable getAllStudents()
        {

            string ConnectionStr = DBConnection.ConnectionStr;
            SqlConnection connection = new SqlConnection(ConnectionStr);

            connection.Open();

            try
            {
                // Execute SQL SELECT statement                
                SqlCommand cmd = new SqlCommand("Select * from students;", connection);
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
