using System;
using System.Text;

namespace QuanLyCanBo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QLCB qlcb = new QLCB();
            while (true)
            {
                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1: Thêm cán bộ");
                Console.WriteLine("2: Hiển thị danh sách cán bộ");
                Console.WriteLine("3: Tìm kiếm cán bộ theo tên");
                Console.WriteLine("4: Thoát");
                Console.Write("Lựa chọn của bạn: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập số.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        qlcb.Input();
                        break;
                    case 2:
                        qlcb.Output();
                        break;
                    case 3:
                        Console.Write("Nhập tên cán bộ cần tìm: ");
                        string name = Console.ReadLine();
                        qlcb.SearchByName(name);
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
