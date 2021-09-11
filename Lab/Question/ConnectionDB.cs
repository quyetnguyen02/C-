using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;

namespace Questions
{
   public class ConnectionDB
    {
        public static SqlConnection GetConnection()
        {
            string constr = @"Data source=QUYETNGUYEN\SQLEXPRESS;
                         initial catalog=managequestion;  user id =sa; password=sa ";

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            
            return conn;
        }
    }
}
