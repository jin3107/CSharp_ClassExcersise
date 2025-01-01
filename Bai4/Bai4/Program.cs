using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            KhuPho khuPho = new KhuPho();
            while (true)
            {
                Console.WriteLine("--- Chức năng ---");
                Console.WriteLine("1. Thêm hộ gia đình");
                Console.WriteLine("2. Hiển thị danh sách hộ gia đình");
                Console.WriteLine("3. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int chon))
                {
                    Console.WriteLine("Lựa chọn phải là số. Vui lòng thử lại.\n");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        khuPho.Nhap();
                        break;
                    case 2:
                        khuPho.Xuat();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.\n");
                        break;
                }
            }
        }
    }
}