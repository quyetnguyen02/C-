using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Questions
{
    class ManageQuestion
    {
        
        SqlConnection conn = ConnectionDB.GetConnection();
        
          Question ques = new Question();
        public  void CreateQuestion(Question a) {
            
            ques.Input();
            SqlCommand cmd;
          SqlDataAdapter  sqlDataAdapter = new SqlDataAdapter();
            string query = " ";
          

            query = "insert into question values(@macauhoi,@tencauhoi, @diem, @dapan,@dapandung)";
           
            
               cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@macauhoi", SqlDbType.NVarChar).Value = a.MaCauHoi;
                cmd.Parameters.Add("@tencauhoi", SqlDbType.NVarChar).Value = a.CauHoi;
                cmd.Parameters.Add("@diem", SqlDbType.Decimal).Value = a.Diem;
                cmd.Parameters.Add("@dapan", SqlDbType.NVarChar).Value = a.Dapan;
                cmd.Parameters.Add("@dapandung", SqlDbType.Char).Value = a.Dapandung;

            cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                Console.WriteLine("ok");
           

        
        }
        public static void EditQuestion() { }

        public static void SelectQuestion() { }

        public static void DeleteQuestion() { }



    }
}
