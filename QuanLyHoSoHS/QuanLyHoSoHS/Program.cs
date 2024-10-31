using System;
using System.Text;

namespace QuanLyHoSoHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truong truong = new Truong();

            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1. Nhập danh sách học sinh");
                Console.WriteLine("2. Hiển thị danh sách học sinh");
                Console.WriteLine("3. Thêm học sinh mới");
                Console.WriteLine("4. Hiển thị học sinh 20 tuổi");
                Console.WriteLine("5. Đếm học sinh 23 tuổi quê ở DN");
                Console.WriteLine("6. Thoát");

                Console.Write("\nLựa chọn của bạn: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("\nNhập số lượng học sinh: ");
                        int soLuongHocSinh;
                        while (!int.TryParse(Console.ReadLine(), out soLuongHocSinh) || soLuongHocSinh <= 0)
                        {
                            Console.WriteLine("Số lượng học sinh phải là số nguyên dương.");
                        }
                        for (int i = 0; i < soLuongHocSinh; i++)
                        {
                            Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");
                            truong.ThemHocSinh();
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Danh sách học sinh ---");
                        truong.DanhSachHocSinh.ForEach(hs => hs.Xuat());
                        break;

                    case 3:
                        Console.WriteLine("\nNhập thông tin học sinh mới:");
                        truong.ThemHocSinh();
                        break;

                    case 4:
                        var hocSinh20Tuoi = truong.LayHocSinh20Tuoi();
                        Console.WriteLine("\nDanh sách học sinh 20 tuổi:");
                        hocSinh20Tuoi.ForEach(hs => hs.Xuat());
                        break;

                    case 5:
                        int soLuongHocSinh23TuoiDN = truong.DemHocSinh23TuoiQueDN();
                        Console.WriteLine($"\nSố lượng học sinh 23 tuổi quê ở DN: {soLuongHocSinh23TuoiDN}");
                        break;

                    case 6:
                        Console.WriteLine("\nThoát chương trình ...");
                        Console.ReadLine();
                        return;
                }
            }
        }
    }
}
