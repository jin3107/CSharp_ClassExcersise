using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            QuanLyCanBo quanLyCanBo = new QuanLyCanBo();
            while(true)
            {
                Console.WriteLine("\n--- Chọn chức năng ---");
                Console.WriteLine("1. Thêm cán bộ");
                Console.WriteLine("2. Tìm kiếm cán bộ theo tên");
                Console.WriteLine("3. Hiển thị danh sách cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("\nLựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int chon))
                {
                    Console.WriteLine("Lựa chọn không đúng định dạng. Nhập lại");
                    continue;
                }

                switch(chon)
                {
                    case 1:
                        quanLyCanBo.ThemCanBo(); break;
                    case 2:
                        Console.Write("Nhập tên cán bộ cần tìm kiếm: ");
                        string ten = Console.ReadLine();
                        quanLyCanBo.TimKiemTheoTen(ten);
                        break;
                    case 3:
                        quanLyCanBo.HienThiCanBo(); break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại!");
                        break;
                }
            }
        }
    }
}
