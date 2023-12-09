using SchoolManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.DL
{
    public  class TeacherDL
    {
        public static void addTeacherIntoDatabase(Teacher teacher)
        {
            SqlConnection connection = DbConnection.getInstance().getConnection();

            // Connect to the database.
            connection.Open();

            try
            {
                // Create and execute the SQL INSERT statement
                using (SqlCommand command = new SqlCommand(@"INSERT INTO teachers (user_id, first_name, last_name, date_of_birth, gender, address, phone_number, email, qualifications, CreatedAt, UpdatedAt, Active) VALUES (@user_id, @first_name, @last_name, @date_of_birth, @gender, @address, @phone_number, @email, @qualifications, @createdAt, @updatedAt, @active)", connection))
                {
                    command.Parameters.AddWithValue("@user_id", teacher.UserId);
                    command.Parameters.AddWithValue("@first_name", teacher.FirstName);
                    command.Parameters.AddWithValue("@last_name", teacher.LastName);
                    command.Parameters.AddWithValue("@date_of_birth", teacher.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", teacher.Gender);
                    command.Parameters.AddWithValue("@address", teacher.Address);
                    command.Parameters.AddWithValue("@phone_number", teacher.PhoneNumber);
                    command.Parameters.AddWithValue("@email", teacher.Email);
                    command.Parameters.AddWithValue("@qualifications", teacher.Qualifications);
                    command.Parameters.AddWithValue("@createdAt", teacher.CreatedAt);
                    command.Parameters.AddWithValue("@updatedAt", teacher.UpdatedAt);
                    command.Parameters.AddWithValue("@active", teacher.Active);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LogsDL.LogException(ex);
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                connection.Close();
            }
        }
        public static DataTable getAllTeachers()
        {
            

                SqlConnection connection = DbConnection.getInstance().getConnection();
                
            connection.Open();

            try
            {
                // Execute SQL SELECT statement                
                SqlCommand cmd = new SqlCommand("Select * from teachers;", connection);
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
