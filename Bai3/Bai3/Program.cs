using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyTuyenSinh quanLyTuyenSinh = new QuanLyTuyenSinh();
            while(true)
            {
                Console.WriteLine("\n\n- Chọn chức năng -");
                Console.WriteLine("1: Thêm thí sinh");
                Console.WriteLine("2: Hiển thị danh sách thí sinh và khối thi của thí sinh");
                Console.WriteLine("3: Tìm kiếm thí sinh theo Số báo danh");
                Console.WriteLine("4: Thoát");
                Console.Write("\nLựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập số.");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        quanLyTuyenSinh.ThemThiSinh();
                        break;
                    case 2:
                        quanLyTuyenSinh.HienThiThiSinh();
                        break;
                    case 3:
                        Console.Write("Nhập số báo danh của thí sinh cần tìm: ");
                        string soBaoDanh = Console.ReadLine();
                        quanLyTuyenSinh.TimKiemTheoSBD(soBaoDanh);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
