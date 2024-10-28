using System;
using System.Text;

namespace QuanLyHoDanCu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();

            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1. Nhập thông tin khu phố");
                Console.WriteLine("2. Hiển thị thông tin khu phố");
                Console.WriteLine("3. Thêm gia đình mới");
                Console.WriteLine("4. Thoát");

                Console.Write("\nLựa chọn của bạn: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                }

                switch (choice)
                {
                    case 1:
                        khuPho.Nhap();
                        break;
                    case 2:
                        khuPho.Xuat();
                        break;
                    case 3:
                        khuPho.ThemGiaDinh();
                        break;
                    case 4:
                        Console.WriteLine("\nThoát chương trình ...");
                        Console.ReadLine();
                        return;
                }
            }
        }
    }
}
