using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            KhachSan quanLyKhachSan = new KhachSan();
            while (true)
            {
                Console.WriteLine("\n--- Chức năng ---");
                Console.WriteLine("1. Thêm khách hàng\n2. Hiển thị khách hàng\n3. Xóa khách hàng\n4. Tính tiền phòng thuê\n5. Thoát");
                Console.Write("Chọn chức năng: ");

                int chon;
                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Lựa chọn phải là dạng số.");
                    continue;
                }

                switch(chon)
                {
                    case 1:
                        quanLyKhachSan.ThemKhachHang();
                        break;
                    case 2:
                        quanLyKhachSan.HienThiKhachHang();
                        break;
                    case 3:
                        Console.Write("\nNhập số chứng minh nhân dân cần xóa: ");
                        string cmnd = Console.ReadLine();
                        quanLyKhachSan.XoaKhachHang(cmnd);
                        break;
                    case 4:
                        Console.Write("\nNhập số chứng minh nhân dân cần tính tiền: ");
                        string cmndTinhTien = Console.ReadLine();
                        quanLyKhachSan.TinhTienThuePhong(cmndTinhTien);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại");
                        break;
                }
            }
        }
    }
}
