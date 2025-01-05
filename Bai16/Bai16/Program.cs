using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
                    
            BTHinhHoc bTHinhHoc = new BTHinhHoc();
            while(true)
            {
                Console.WriteLine("\n-- Chức năng --");
                Console.WriteLine("1. Thêm hình học\n2. Hiển thị kết quả\n3. Thoát");

                Console.Write("Lựa chọn của bạn: ");
                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Nhập sai định dạng. Vui lòng nhập lại.\n");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        bTHinhHoc.ThemHinhHoc();
                        break;
                    case 2:
                        bTHinhHoc.HienThiHinhHoc();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.\n");
                        break;
                }
            }
        }
    }
}