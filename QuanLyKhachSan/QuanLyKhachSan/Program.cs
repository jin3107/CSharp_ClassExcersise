using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhachSan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            KhachSan khachSan = new KhachSan();
            while (true)
            {
                Console.WriteLine("===== Quản Lý Khách Sạn =====");
                Console.WriteLine("1. Thêm khách thuê");
                Console.WriteLine("2. Xóa khách thuê");
                Console.WriteLine("3. Tính tiền thuê phòng");
                Console.WriteLine("4. Hiển thị danh sách khách");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng (1-5): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Nguoi nguoiMoi = new Nguoi();
                        nguoiMoi.Nhap();
                        khachSan.Them(nguoiMoi);
                        Console.WriteLine("Thêm khách thành công!\n");
                        break;

                    case "2":
                        Console.Write("\nNhập CMND của khách cần xóa: ");
                        string cmndXoa = Console.ReadLine();
                        khachSan.Xoa(cmndXoa);
                        Console.WriteLine("Xóa khách thành công!\n");
                        break;

                    case "3":
                        Console.Write("\nNhập CMND của khách cần tính tiền: ");
                        string cmndTinhTien = Console.ReadLine();
                        int tien = khachSan.TinhTien(cmndTinhTien);
                        if (tien > 0)
                            Console.WriteLine($"Tổng tiền khách phải trả: {tien} VNĐ\n");
                        else
                            Console.WriteLine("Không tìm thấy khách với CMND đã nhập.\n");
                        break;

                    case "4":
                        Console.WriteLine("\n\t--- Danh sách khách thuê ---");
                        foreach (var nguoi in khachSan.DanhSachNguoi)
                        {
                            nguoi.Xuat();
                        }
                        break;

                    case "5":
                        Console.WriteLine("Cảm ơn đã sử dụng chương trình!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!\n");
                        break;
                }
            }
        }
    }
}

