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
            QLGDND quanlyGiaoDienNguoiDung = new QLGDND();

            while (true)
            {
                Console.Clear(); // Clear màn hình khi hiển thị menu chính
                Console.WriteLine("\n--- Ứng Dụng Quản Lý Nhân Viên ---");
                Console.WriteLine("1. Thêm Nhân viên");
                Console.WriteLine("2. Cập nhật Nhân viên");
                Console.WriteLine("3. Xóa Nhân viên");
                Console.WriteLine("4. Hiển thị tất cả Nhân viên");
                Console.WriteLine("5. Thoát");
                Console.Write("\nLựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\n[❌] Vui lòng nhập một số hợp lệ.");
                    Console.WriteLine("Nhấn Enter để tiếp tục...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear(); // Clear màn hình khi chọn "Thêm Nhân viên"
                        Console.WriteLine("\n--- Thêm Nhân viên ---");
                        Console.WriteLine("0: Kinh Nghiệm\n1: Mới Tốt Nghiệp\n2: Thực Tập");
                        Console.Write("\nLựa chọn loại nhân viên: ");
                        if (!int.TryParse(Console.ReadLine(), out int type) || type < 0 || type > 2)
                        {
                            Console.WriteLine("\n[❌] Lựa chọn không hợp lệ.");
                        }
                        else
                        {
                            quanlyGiaoDienNguoiDung.Them(type);
                        }
                        Console.WriteLine("\nNhấn Enter để quay lại menu...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear(); // Clear màn hình khi chọn "Cập nhật Nhân viên"
                        Console.WriteLine("\n--- Cập nhật Nhân viên ---");
                        quanlyGiaoDienNguoiDung.CapNhat();
                        Console.WriteLine("\nNhấn Enter để quay lại menu...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear(); // Clear màn hình khi chọn "Xóa Nhân viên"
                        Console.WriteLine("\n--- Xóa Nhân viên ---");
                        quanlyGiaoDienNguoiDung.Xoa();
                        Console.WriteLine("\nNhấn Enter để quay lại menu...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear(); // Clear màn hình khi chọn "Hiển thị tất cả Nhân viên"
                        Console.WriteLine("\n--- Danh sách Nhân viên ---");
                        quanlyGiaoDienNguoiDung.HienThiTatCaNhanVien();
                        Console.WriteLine("\nNhấn Enter để quay lại menu...");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear(); // Clear màn hình khi chọn "Thoát"
                        Console.WriteLine("Thoát Chương Trình...");
                        return;

                    default:
                        Console.WriteLine("\n[❌] Lựa chọn không hợp lệ. Vui lòng nhập từ 1 đến 5.");
                        Console.WriteLine("Nhấn Enter để tiếp tục...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
