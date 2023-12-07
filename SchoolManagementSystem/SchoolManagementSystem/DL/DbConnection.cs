using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagementSystem.DL
{
    public class DbConnection
    {
        private SqlConnection connection;

        public DbConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SchoolManagementSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
