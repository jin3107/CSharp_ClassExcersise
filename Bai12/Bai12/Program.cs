using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyPhuongTien quanLyPhuongTien = new QuanLyPhuongTien();
            while (true)
            {
                Console.WriteLine("\n1. Thêm phương tiện");
                Console.WriteLine("2. Xóa phương tiện");
                Console.WriteLine("3. Tìm phương tiện theo hãng/màu sản xuất");
                Console.WriteLine("4. Xem danh sách phương tiện");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out int chon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập số.");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        quanLyPhuongTien.Nhap();
                        break;
                    case 2:
                        quanLyPhuongTien.Xoa();
                        break;
                    case 3:
                        quanLyPhuongTien.TimKiem();
                        break;
                    case 4:
                        quanLyPhuongTien.Xuat();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}