using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Question
    {
        string[] dapAn = new string[4];
        char dapAnDung ;
        string cauHoi;
        decimal diem;
        
        string maCauhoi;


       
        public string MaCauHoi { get; set; }
        public string CauHoi { get; set; }
        public decimal Diem { get; set; }
        public string Dapan { get; set; }
        public char Dapandung { get; set; }

        public Question() { }
        public Question( string maCauHoi, string cauHoi, decimal diem, string[] dapAn, char dapAnDung)
        {
           
            this.MaCauHoi = maCauHoi;
            this.CauHoi = cauHoi;
            this.Diem = diem;
            this.dapAn = dapAn;
            this.dapAnDung = dapAnDung;
        }
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
           
            Console.Write("Nhập Mã Câu Hỏi: ");
            MaCauHoi = Console.ReadLine();
            Console.Write("Nhập Câu Hỏi: ");
            cauHoi = Console.ReadLine();
            Console.Write("Nhập Điểm: ");
            diem = decimal.Parse(Console.ReadLine());


            for (int i = 0; i < dapAn.Length; i++)
            {
                Console.Write("Nhập Đáp Án :  ");
                dapAn[i] = Console.ReadLine();

                

            }
            Console.Write("Đáp Án  Đúng :  ");
            dapAnDung = char.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ma danh muc: {0}");
            Console.WriteLine("Ma Cau hoi: {0}", MaCauHoi);
            Console.WriteLine("Ten cau hoi: {0}", cauHoi);
            Console.WriteLine("Diem: {0}", diem);
            for (int i = 0; i < dapAn.Length; i++)
            {
                Console.WriteLine("Đáp Án:{0} ", dapAn[i]);
                Console.WriteLine("Đáp Án  Đúng Hay Sai (D/S): {0} ", dapAn);
            }
            Console.WriteLine("");
        }

        public void Edit()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Câu Hỏi: ");
            cauHoi = Console.ReadLine();
            Console.WriteLine("Nhập Điểm: ");
            diem = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < dapAn.Length; i++)
            {
                Console.WriteLine("Nhap dap an : ");
                dapAn[i] = Console.ReadLine();

                Console.Write("Đáp Án  Đúng Hay Sai (D/S):  ");
                dapAnDung = char.Parse(Console.ReadLine());
            }
        }
    }
}
