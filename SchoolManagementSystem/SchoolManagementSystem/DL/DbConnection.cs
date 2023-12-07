using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagementSystem.DL
{
    class DbConnection
    {
        String ConnectionStr = @"Data Source=(local);Initial Catalog=SchoolManagementSystem;Integrated Security=True";
        SqlConnection con;
        private static DbConnection _instance;
        public static DbConnection getInstance()
        {
            if (_instance == null)
                _instance = new DbConnection();
            return _instance;
        }
        private DbConnection()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
