using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            CanBoGiaoVien canBoGiaoVien = new CanBoGiaoVien();
            while(true)
            {
                Console.WriteLine("\n-- Chức năng --");
                Console.WriteLine("1. Thêm cán bộ giáo viên.");
                Console.WriteLine("2. Xóa cán bộ giáo viên.");
                Console.WriteLine("3. Hiển thị cán bộ giáo viên.");
                Console.WriteLine("4. Thoát.");

                Console.Write("Chọn chức năng: ");
                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Lựa chọn không đúng định dạng. Nhập lại\n");
                    continue;
                }

                switch(luaChon)
                {
                    case 1:
                        canBoGiaoVien.ThemCanBoGiaoVien();
                        break;
                    case 2:
                        canBoGiaoVien.XoaCanBoGiaoVien();
                        break;
                    case 3:
                        canBoGiaoVien.HienThiGiaoVien();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại\n");
                        break;
                }
            }
        }
    }
}