using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Group_Lab_2
{
    class Questions
    {
        public string maDanhMuc;
        public string maCauHoi;
        public string tenCauHoi;
        public double diemSo;
        public string[] dapAn=new string[4];
        public char ketQuaDapAn;

        
        public Questions()
        {

        }

        public Questions(string maDanhMuc, string maCauHoi, string tenCauHoi, double diemSo, string dapAn, char ketQuaDapAn, string danhMuc, string id, string name, double diem, char ketQua)
        {
            this.MaDanhMuc = maDanhMuc;
            this.MaCauHoi = maCauHoi;
            this.TenCauHoi = tenCauHoi;
            this.DiemSo = diemSo;      
            this.KetQuaDapAn = ketQuaDapAn;
            this.DapAn = dapAn;
        }

        public string MaDanhMuc { get; set; }
        public string MaCauHoi { get; set; }
        public string  TenCauHoi { get; set; }
        public double DiemSo { get; set; }
        public String DapAn { get; set; }
        public char KetQuaDapAn { get; set; }

        public void CheckDanhMuc()
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (MaDanhMuc== "G001")
            {
                Console.WriteLine("Đây là lĩnh vực Kiến thức phổ thông");

            }
            else if (MaDanhMuc == "G002")
            {
                Console.WriteLine("Đây là lĩnh vực Kiến thức C#");
            }
            else
            {
                Console.WriteLine("Đây là lĩnh vực Kiến thức Toán ");
            }
        }

        public void input()
        {
            Console.WriteLine("Nhap Ma Danh Muc: ");
            MaDanhMuc = Console.ReadLine();
            CheckDanhMuc();
            Console.WriteLine("Nhap Ma Cau Hoi: ");
            MaCauHoi = Console.ReadLine();
            Console.WriteLine("Nhap Cau Hoi:");
            TenCauHoi = Console.ReadLine();
            Console.WriteLine("Nhap Diem:");
            DiemSo = double.Parse(Console.ReadLine());
            for (int i = 1; i <=4 ; i++)
            {
                Write("Đáp án{0}: ", i);
                DapAn = ReadLine();
                Write("Đúng/Sai?(D/S): {0}", KetQuaDapAn);
                KetQuaDapAn = ToChar(ReadLine());
            }
          

        }

        public void Display1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mã Danh Mục: {0}", maDanhMuc);
            Console.WriteLine("Mã Câu Hỏi: {0}", maCauHoi);
            Console.WriteLine("Tên Câu Hổi: {0}", tenCauHoi);
            Console.WriteLine("Điểm Số: {0}", diemSo);
            for(int i= 0; i < 4; i++)
            {
                Console.WriteLine("Dáp Án: {0}", dapAn);
            }         
            Console.WriteLine("Kết Quả đáp Án: {0}", ketQuaDapAn);
            
        }


    }
}
