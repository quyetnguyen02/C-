using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Example12
{
   public class ConnectionDB
    {
        public SqlConnection GetConnection()
        {
            string constr = @"Data source=QUYETNGUYEN\SQLEXPRESS;
                          initial catalog=exxample;user id =sa; password=sa";
            SqlConnection conn;
            conn = new SqlConnection(constr);

            conn.Open();
            Console.WriteLine("COnnected db");
            
            return conn;
        }
    }
}
