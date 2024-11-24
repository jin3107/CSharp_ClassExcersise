using QuanLyNhanVien_Modern.GiaoDien;
using System;
using System.Text;

namespace MainApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            QLGDND quanlyGaioDienNguoiDung = new QLGDND();


            while (true)
            {
                Console.WriteLine("\n--- Ứng Dụng Quản Lý Nhân Viên ---");
                Console.WriteLine("1. Thêm Nhân viên");
                Console.WriteLine("2. Cập nhật Nhân viên");
                Console.WriteLine("3. Xóa Nhân viên");
                Console.WriteLine("4. Hiển thị tất cả Nhân viên");
                Console.WriteLine("5. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n0: Kinh Nghiệm\n1: Mới Tốt Nghiệp\n2: Thực Tập");
                        Console.Write("Lựa chọn của bạn: ");
                        int type = int.Parse(Console.ReadLine());
                        quanlyGaioDienNguoiDung.Them(type);
                        break;
                    case 2:
                        quanlyGaioDienNguoiDung.CapNhat();
                        break;
                    case 3:
                        quanlyGaioDienNguoiDung.Xoa();
                        break;
                    case 4:
                        quanlyGaioDienNguoiDung.HienThiTatCaNhanVien();
                        break;
                    case 5:
                        Console.WriteLine("Thoát Chương Trình...");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại");
                        break;
                }
            }
        }
    }
}
