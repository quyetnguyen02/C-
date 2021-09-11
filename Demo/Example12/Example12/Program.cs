using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Example12
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Connect();
            CreatCustomer();
            GetAllCustomer();
            Console.ReadLine();
            

        }
       static SqlConnection Connect()
        {
            string constr = @"Data source=QUYETNGUYEN\SQLEXPRESS;
                          initial catalog=exxample;user id =sa; password=sa";
            SqlConnection conn;
            conn = new SqlConnection(constr);

            conn.Open();
            Console.WriteLine("COnnected db");
           
            return conn;

        }


        static void GetAllCustomer()
        {
            string constr = @"Data source=QUYETNGUYEN\SQLEXPRESS;
                          initial catalog=exxample;user id =sa; password=sa";
            SqlConnection conn;
            conn = new SqlConnection(constr);

            conn.Open();

            SqlCommand cmd;

            SqlDataReader dataReader;
            string query = "select * from customer";
            string ouput = "";
            cmd = new SqlCommand(query,conn);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())//ResultSet rs
            {
               ouput=ouput + dataReader.GetValue(0)+"-" + 
                    dataReader.GetValue(1)+ " " + dataReader.GetValue(2) + "\n";

            }
            Console.WriteLine(ouput);

            dataReader.Close();
            cmd.Dispose();
            conn.Close();

        }

        static void CreatCustomer()
        {
            SqlConnection conn = Connect();

            SqlCommand cmd;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            
            string query= "";
            query="insert into customer values (4,'tran','thi trang')";
                cmd = new SqlCommand(query, conn);
            sqlDataAdapter.InsertCommand = new SqlCommand(query, conn);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            
            
            cmd.Dispose();
            conn.Close();


        }
    }
}
