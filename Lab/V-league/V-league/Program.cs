using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_league
{

    class Program
    {

        //Menu chinh
        public static void MenuCHinh()
    {
        Console.WriteLine("--Chào mừng đến với V-League 2021-----");
        Console.WriteLine("\n=================================");
        Console.WriteLine("1. Quản lý danh sách đội bóng.");
        Console.WriteLine("2. Quản lý lịch thi đấu");
        Console.WriteLine("3. Quản lý kết quả thi đấu.");
        Console.WriteLine("4. Bảng xếp hạng");
        Console.WriteLine("0. Thoát.");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                QLDSDoiBong();
                break;
            case 2: QLLichTHiDau();
                break;
            case 3: KetQua();
                break;
            case 4: BangXepHang();
                break;
            case 0:
                break;
            default:
                break;
        }

    }

    //Quan ly ds doi bong
    public static void QLDSDoiBong()
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine("1. Xem danh sách đội bóng.");
        Console.WriteLine("2. Cập nhật danh sách đội bóng");
        Console.WriteLine("3. Thêm mới một đội bóng");
        Console.WriteLine("0. Trở về menu chính.");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                XemDSDoiBong();
                break;
            case 2:
                UpdateDoiBong();
                break;
            case 3:
                ThemDoiBong();
                break;
            case 0:
                MenuCHinh();
                break;
            default:
                break;
        }
    }

    //them moi doi bong
    public static void ThemDoiBong()
    {
        Console.WriteLine("\n=====Thêm mới một đội bóng=======");
        Console.WriteLine("Nhập Mã đội: TC08");
        Console.WriteLine("Nhập tên đôi: Thể Công");
        Console.WriteLine("Nhập tên huấn luyện viên: Vương Tiến Dũn.");
        Console.WriteLine("Bạn muốn tiếp tục?(Y/N)");
        string b = Console.ReadLine();
        if (b == "Y")
        {
            ThemDoiBong();

        }
        else if (b == "N")
        {
            QLDSDoiBong();
        }


    }

    //Cap nhat thong tin doi bong
    public static void UpdateDoiBong()
    {
        Console.WriteLine("\n======Cập nhật thông tin đội bóng=================");
        Console.WriteLine("Nhập Mã đội: TC08");
        Console.WriteLine("Sửa Tên đội: Thể Công – Viettel");
        Console.WriteLine("Sửa Tên huấn luyện viên: Nguyễn Hồng Sơn");
        Console.WriteLine("Bạn có muốn cập nhật thông tin?(Y/N)");
        string b = Console.ReadLine();
        do
        {
            Console.WriteLine("Bạn có muốn cập nhật thông tin?(Y/N)");
            b = Console.ReadLine();
        } while (b == "N");
        if (b == "Y")
        {

            Console.WriteLine("Thông tin về đã được cập nhật!");
            Console.WriteLine("Bạn muốn tiếp tục?(Y/N)");
            string d = Console.ReadLine();
            if (d == "N")
            {
                QLDSDoiBong();
            }
            else if (d == "Y")
            {
                UpdateDoiBong();
            }
        }




    }

    //Xem ds doi bong
    public static void XemDSDoiBong()
    {
        Console.WriteLine("================================================");
        Console.WriteLine("| Mã đội | Tên đội           | Huấn luyện viên |");
        Console.WriteLine("================================================");
        Console.WriteLine("| TC08   | Thể công- Viettel | Nguyễn Hồng Sơn |");
        Console.WriteLine("| HAGL   | Hoàng Anh Gia Lai | Mai Đức Chung   |");
        Console.WriteLine("================================================");
        Console.WriteLine("================================================");
        Console.WriteLine("0:Thoat");
        int a = Convert.ToInt32(Console.ReadLine());
        QLDSDoiBong();

    }

    //quan ly lich thi dau
    public static void QLLichTHiDau()
    {
        Console.WriteLine("1. Xem lịch thi đấu");
        Console.WriteLine("2. Cập nhật cập nhật lịch thi đấu");
        Console.WriteLine("3. Tạo lịch thi đấu");
        Console.WriteLine("0. Trở về menu chính");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Chưa có thông tin!");
                Console.WriteLine("0:Thoat");
                int b = Convert.ToInt32(Console.ReadLine());
                    QLLichTHiDau();
                break;
            case 2:
                Console.WriteLine("Chưa có thông tin!");
                Console.WriteLine("0:Thoat");
                int c = Convert.ToInt32(Console.ReadLine());
                    QLLichTHiDau();
                break;
            case 3:
                CreateLichThiDau();
                break;
            case 0:
                MenuCHinh();
                break;
            default:
                break;
        }
    }

    //Tao lich thi dau
    public static void CreateLichThiDau()
    {
        Console.WriteLine("=====Tạo lịch thi đấu=======");
        Console.WriteLine("1. Thể Công – Viettel vs Hoàng Anh Gia Lai");
        Console.WriteLine("2. SLNA vs Hải Phòng");
        Console.WriteLine("0. Trở về menu chính");
        Console.WriteLine("Chọn để xem chi tiết trận đấu:");

        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Chưa có thông tin!");
                Console.WriteLine("0:Thoat");
                int b = Convert.ToInt32(Console.ReadLine());
                    CreateLichThiDau();
                break;
            case 2:
                TranDau();
                break;
            case 0: MenuCHinh();
                break;
            default:
                break;


        }
    }

    //chi tiet tran dau
    public static void TranDau()
    {
        Console.WriteLine("Trận: SLNA vs Hải Phòng");
        Console.WriteLine("Ngày thi đấu: 30/8/2021");
        Console.WriteLine("Giờ thi đấu: 15h30");
        Console.WriteLine("Sân thi đấu: Sân Vinh");
        Console.WriteLine("Bạn muốn cập nhật?(Y/N)");
        string b = Console.ReadLine();
        do
        {
            Console.WriteLine("Bạn có muốn cập nhật thông tin?(Y/N)");
            b = Console.ReadLine();
        } while (b == "N");
        if (b == "Y")
        {

            Console.WriteLine("Thông tin về đã được cập nhật!");
            Console.WriteLine("Bạn muốn tiếp tục?(Y/N)");
            string d = Console.ReadLine();
            if (d == "N")
            {
                QLLichTHiDau();
            }
            else if (d == "Y")
            {
                TranDau();
            }
        }

    }

    //ket  qua thi dau
    public static void KetQua()
    {
        Console.WriteLine("=====Kết quả thi đấu=======");
        Console.WriteLine("1. Thể Công – Viettel 3 - 0 Hoàng Anh Gia Lai");
        Console.WriteLine("2. SLNA vs Hải Phòng");
        Console.WriteLine("0. Trở về menu chính");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                ChiTietTranDau1();
                break;
            case 2:
                ChiTietTranDau2();
                break;
            case 0: MenuCHinh();
                break;
            default:
                break;


        }
    }
    //chi tiet tran dau 1
    public static void ChiTietTranDau1()
    {
        Console.WriteLine("Trận: Thể Công - Viettel  vs Hoàng Anh Gia Lai ");
        Console.WriteLine("Kết quả Thể Công – Viettel: 3");
        Console.WriteLine("Kết quảHoàng Anh Gia Lai: 0");
        Console.WriteLine("0:Thoat");
        int a = Convert.ToInt32(Console.ReadLine());
            KetQua();


    }
    //chi tiet tran dau2
    public static void ChiTietTranDau2()
    {
        Console.WriteLine("Trận: SLNA vs Hải Phòng");
        Console.WriteLine("Kết quả SLNA: 2");
        Console.WriteLine("Kết quả Hải Phòng: 1");
        Console.WriteLine("0:Thoat");
        int a = Convert.ToInt32(Console.ReadLine());
            KetQua();

    }

    //bang xep hang

    public static void BangXepHang()
    {
        Console.WriteLine("=================================================================");
        Console.WriteLine("| Mã đội | Tên đội           | Trận | Thắng | Hòa | Thua | Điểm |");
        Console.WriteLine("=================================================================");
        Console.WriteLine("| TC08   | Thể công- Viettel | 20   |   10  |  2  |  0   | 32   |");
        Console.WriteLine("| HAGL   | Hoàng Anh Gia Lai | 19   |   9   |  4  |  1   | 31   |");
        Console.WriteLine("=================================================================");
        Console.WriteLine("0:Thoat");
        int a = Convert.ToInt32(Console.ReadLine());
            MenuCHinh();

    }


    

        static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

            MenuCHinh();

            }


        }
    }

