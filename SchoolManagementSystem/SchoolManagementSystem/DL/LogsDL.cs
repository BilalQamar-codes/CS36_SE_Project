
//LogsDL class logs exceptions to a 'logs' database table. 
//The LogException method captures exception details and stores them using an SQL INSERT statement.
//To use this functionality, call the static LogException method and pass an Exception object to log 
//relevant details to the connected database for further analysis and debugging purposes.
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DL
{
    public class LogsDL
    {
        public static void LogException(Exception exception)
        {
            // Extract relevant information from the exception
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            string level = exception.GetType().Name;
            string message = exception.Message;
            string className = exception.Source;
            string functionName = exception.TargetSite.Name;
            string stackTrace = exception.StackTrace;

            // Open a connection to the database
            SqlConnection connection = new SqlConnection(DBConnection.ConnectionStr);
            connection.Open();
            
            
            

            // Create and execute the SQL INSERT statement
            using (SqlCommand command = new SqlCommand(@"INSERT INTO logs (timestamp, level, message, class_name, function_name, stack_trace) VALUES (@timestamp, @level, @message, @className, @functionName, @stackTrace)", connection))
            {
                command.Parameters.AddWithValue("@timestamp", timestamp);
                command.Parameters.AddWithValue("@level", level);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@className", className);
                command.Parameters.AddWithValue("@functionName", functionName);
                command.Parameters.AddWithValue("@stackTrace", stackTrace);

                command.ExecuteNonQuery();
            }

            // Close the connection
            connection.Close();
        }

    }
}
