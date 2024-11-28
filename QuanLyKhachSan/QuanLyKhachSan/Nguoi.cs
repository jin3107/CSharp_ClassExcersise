using System;
using System.Text;

namespace QuanLyKhachSan
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Cmnd { get; set; }
        public Phong PhongThue { get; set; }
        public int SoNgayThue { get; set; }

        public Nguoi() { }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0)
                {
                    Tuoi = tuoi;
                    break;
                }
                Console.WriteLine("Tuổi là một số nguyên dương.");
            }

            Console.Write("Nhập CMND: ");
            Cmnd = Console.ReadLine();

            Console.Write("Chọn loại phòng (A, B, C): ");
            string loaiPhong = Console.ReadLine().ToUpper();
            switch (loaiPhong)
            {
                case "A":
                    PhongThue = new Phong("A", 500);
                    break;
                case "B":
                    PhongThue = new Phong("B", 300);
                    break;
                case "C":
                    PhongThue = new Phong("C", 100);
                    break;
                default:
                    throw new ArgumentException("Loại phòng không hợp lệ.");
            }

            while (true)
            {
                Console.Write("Nhập số ngày thuê: ");
                if (int.TryParse(Console.ReadLine(), out int soNgay) && soNgay > 0)
                {
                    SoNgayThue = soNgay;
                    break;
                }
                Console.WriteLine("Số ngày thuê phải là số nguyên dương.");
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tên: {HoTen}, Tuổi: {Tuoi}, CMND: {Cmnd}");
            Console.WriteLine($"Phòng: {PhongThue.LoaiPhong}, Giá: {PhongThue.GiaPhong}, Số ngày thuê: {SoNgayThue}");
            Console.WriteLine($"Tổng tiền: {PhongThue.GiaPhong * SoNgayThue} VNĐ\n");
        }
    }
}
