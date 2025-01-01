using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Cmnd { get; set; }

        public Phong PhongThue { get; set; } = new Phong();

        public Nguoi() { }

        public Nguoi(string hoTen, int tuoi, string cmnd, Phong phongThue)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            Cmnd = cmnd;
            PhongThue = phongThue;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0 && tuoi <= 100)
                {
                    Tuoi = tuoi;
                    break;
                }
                else
                    Console.WriteLine("Tuổi phải là số nguyên dương");
            }

            Console.Write("Nhập số chứng minh nhân dân: ");
            Cmnd = Console.ReadLine();

            Console.Write("Chọn loại phòng (A, B hoặc C): ");
            string loaiPhong = Console.ReadLine().ToUpper();
            switch (loaiPhong)
            {
                case "A":
                    PhongThue.LoaiPhong = "A";
                    PhongThue.GiaPhong = 500;
                    break;
                case "B":
                    PhongThue.LoaiPhong = "B";
                    PhongThue.GiaPhong = 300;
                    break;
                case "C":
                    PhongThue.LoaiPhong = "C";
                    PhongThue.GiaPhong = 100;
                    break;
                default:
                    Console.WriteLine("Loại phòng không hợp lệ");
                    break;
            }
            PhongThue.Nhap();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Số chứng minh nhân dân: {Cmnd}");
            PhongThue.Xuat();
        }
    }
}
