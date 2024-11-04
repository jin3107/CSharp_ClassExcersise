using System;
using System.Text;

namespace QuanLyTuyenSinh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QLTS quanLyThiSinh = new QLTS();
            while (true)
            {
                Console.WriteLine("\n\nChọn chức năng:");
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
                        quanLyThiSinh.Input();
                        break;
                    case 2:
                        quanLyThiSinh.Output();
                        break;
                    case 3:
                        Console.Write("Nhập số báo danh của thí sinh cần tìm: ");
                        string soBaoDanh = Console.ReadLine();
                        ThiSinh thiSinh = quanLyThiSinh.Search(soBaoDanh);
                        if (thiSinh != null)
                        {
                            Console.WriteLine("\nThông tin thí sinh tìm thấy:");
                            thiSinh.Xuat();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy thí sinh với số báo danh đã nhập.");
                        }
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
