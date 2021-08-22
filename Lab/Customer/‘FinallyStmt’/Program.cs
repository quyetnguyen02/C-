using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _FinallyStmt_
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                //mo file de ghi du lieu
                outStream = File.OpenWrite("DestinationFile.txt");
                //mo file de doc du lieu
                inStream = File.OpenRead("BogusInputFile.txt");
                //cac cau lenh doc du lieu tu file
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if(outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outStream closed.");
                }
                if(inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed.");
                }
            }
        }
    }
}
