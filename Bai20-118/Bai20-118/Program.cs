using System;
using System.Linq;
using System.Text;

namespace Bai20_118
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyXetTuyen quanLyXetTuyen = new QuanLyXetTuyen();
            while(true)
            {
                Console.WriteLine("\n-- Chức năng --");
                Console.WriteLine("1. Thêm học viên");
                Console.WriteLine("2. Hiển thị học viên");
                Console.WriteLine("3. Sửa học viên");
                Console.WriteLine("4. Xóa học viên");
                Console.WriteLine("5. Tìm kiếm học viên");
                Console.WriteLine("6. Trạng thái kiểm tra xét tuyển");
                Console.WriteLine("7. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                int chon = int.Parse(Console.ReadLine());

                switch(chon)
                {
                    case 1:
                        quanLyXetTuyen.ThemHocVien();
                        break;
                    case 2:
                        quanLyXetTuyen.HienThiHocVien();
                        break;
                    case 3:
                        Console.Write("\nNhập tên học viên cần sửa: ");
                        string hoTen = Console.ReadLine();
                        if (hoTen != null)
                            quanLyXetTuyen.SuaHocVien(hoTen);
                        else
                        {
                            Console.WriteLine("Không tìm thấy học viên cần sửa");
                            return;
                        }
                        break;
                    case 4:
                        Console.Write("\nNhập tên học viên cần xóa: ");
                        string hoTenXoa = Console.ReadLine();
                        if (hoTenXoa != null)
                            quanLyXetTuyen.XoaHocVien(hoTenXoa);
                        else
                        {
                            Console.WriteLine("Không tìm thấy học viên cần xóa");
                            return;
                        }
                        break;
                    case 5:
                        Console.Write("\nNhập tên học viên cần tìm: ");
                        string hoTenTimKiem = Console.ReadLine();
                        if (hoTenTimKiem != null)
                            quanLyXetTuyen.TimKiemHocVien(hoTenTimKiem);
                        else
                        {
                            Console.WriteLine("Không tìm thấy học viên cần tìm");
                            return;
                        }
                        break;
                    case 6:
                        quanLyXetTuyen.TrangThaiXetTuyen();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại!");
                        break;
                }
            }
        }
    }
}