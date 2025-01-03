using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyHoSoHS quanLyHoSoHS = new QuanLyHoSoHS();
            while (true)
            {
                Console.WriteLine("\n-- Menu --");
                Console.WriteLine("1. Thêm học sinh mới");
                Console.WriteLine("2. Hiện thị các học sinh 20 tuổi");
                Console.WriteLine("3. Hiện thị số lượng học sinh 23 tuổi và quê ở Đà Nẵng");
                Console.WriteLine("4. Hiện thị danh sách học sinh");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out int chon))
                {
                    Console.WriteLine("Nhập lựa chọn không đúng định dạng. Nhập lại\n");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        quanLyHoSoHS.ThemHocSinh();
                        break;
                    case 2:
                        quanLyHoSoHS.HienThiHocSinh20Tuoi();
                        break;
                    case 3:
                        quanLyHoSoHS.HienThiHocSinh23TuoiDaNang();
                        break;
                    case 4:
                        quanLyHoSoHS.HienThiDanhSachHocSinh();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
        }
    }
}
