using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QLS qLS = new QLS();
            while (true)
            {
                Console.WriteLine("\n\nChọn chức năng:");
                Console.WriteLine("1: Thêm tài liệu");
                Console.WriteLine("2: Tìm kiếm tài liệu theo loại");
                Console.WriteLine("3: Hiển thị danh sách tài liệu");
                Console.WriteLine("4: Xóa tài liệu theo Mã tài liệu");
                Console.WriteLine("5: Thoát");
                Console.Write("\nLựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập số.");
                    continue;
                }
                switch (luaChon)
                {
                    case 1:
                        qLS.Input(); break;
                    case 2:
                        Console.WriteLine("Chọn loại tài liệu để tìm kiếm.");
                        Console.WriteLine("1. Sách");
                        Console.WriteLine("2. Tạp Chí");
                        Console.WriteLine("3. Báo\n");
                        Console.Write("Lựa chọn của bạn: ");

                        if (!int.TryParse(Console.ReadLine(), out int loaiTimKiem) || loaiTimKiem < 1 || loaiTimKiem > 3)
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                        }

                        switch (loaiTimKiem)
                        {
                            case 1: 
                                qLS.TimSach(); break;
                            case 2:
                                qLS.TimTapChi(); break;
                            case 3:
                                qLS.TimBao(); break;
                        }   break;
                    case 3:
                        qLS.Output(); break;
                    case 4:
                        Console.Write("Nhập mã tài liệu cần xóa: ");
                        string id = Console.ReadLine();
                        if (qLS.XoaTaiLieu(id))
                            Console.WriteLine("Xóa thành công");
                        else
                            Console.WriteLine("Mã tài liệu không tồn tại.");
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình."); return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ."); break;
                }
            }
        }
    }
}