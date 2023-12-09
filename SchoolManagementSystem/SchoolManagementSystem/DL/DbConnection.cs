using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagementSystem.DL
{
    class DBConnection
    {
        public static string ConnectionStr = @"Data Source=(local);Initial Catalog=SchoolManagementSystem;Integrated Security=True";
        SqlConnection con;
        private static DBConnection _instance;
        public static DBConnection getInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }
        private DBConnection()
        {
            con = new SqlConnection(ConnectionStr);
            
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
