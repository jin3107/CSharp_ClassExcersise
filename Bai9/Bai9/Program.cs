using System;
using System.Text;

namespace Bai9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyBienLai quanLy = new QuanLyBienLai();

            while (true)
            {
                Console.WriteLine("\n--- Quản lý biên lai tiền điện ---");
                Console.WriteLine("1. Thêm biên lai");
                Console.WriteLine("2. Xóa biên lai");
                Console.WriteLine("3. Sửa thông tin biên lai");
                Console.WriteLine("4. Hiển thị danh sách biên lai");
                Console.WriteLine("5. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số từ 1 đến 5.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        quanLy.ThemBienLai();
                        break;
                    case 2:
                        Console.Write("Nhập mã công tơ điện cần xóa: ");
                        string maXoa = Console.ReadLine();
                        quanLy.XoaBienLai(maXoa);
                        break;
                    case 3:
                        Console.Write("Nhập mã công tơ điện cần sửa: ");
                        string maSua = Console.ReadLine();
                        quanLy.SuaThongTinBienLai(maSua);
                        break;
                    case 4:
                        quanLy.HienThiDanhSachBienLai();
                        break;
                    case 5:
                        Console.WriteLine("Chương trình kết thúc.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 5.");
                        break;
                }
            }
        }
    }
}
