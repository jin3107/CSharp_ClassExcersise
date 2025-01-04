using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Nguoi
    {
        public string MaSoGV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string QueQuan { get; set; }
        public double LuongCung { get; set; }
        public double LuongThuong { get; set; }
        public double TienPhat { get; set; }
        public double LuongThucLinh { get; set; }

        public Nguoi(string maSoGV, string hoTen, int tuoi, string queQuan,
            double luongCung, double luongThuong, double tienPhat, double luongThucLinh)
        {
            MaSoGV = maSoGV;
            HoTen = hoTen;
            Tuoi = tuoi;
            QueQuan = queQuan;
            LuongCung = luongCung;
            LuongThuong = luongThuong;
            TienPhat = tienPhat;
            LuongThucLinh = luongThucLinh;
        }

        public Nguoi() { }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập mã số giáo viên: ");
            MaSoGV = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi)
                    && tuoi > 0 && tuoi <= 100)
                {
                    Tuoi = tuoi;
                    break;
                }
                else
                {
                    Console.WriteLine("Tuổi phải là số nguyên dương và nhỏ hơn 100.");
                }
            }

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập lương cứng: ");
                if (double.TryParse(Console.ReadLine(), out double luongCung)
                    && luongCung >= 0)
                {
                    LuongCung = luongCung;
                    break;
                }
                else
                {
                    Console.WriteLine("Lương cứng phải là số thực không âm.");
                }
            }

            while (true)
            {
                Console.Write("Nhập lương thưởng: ");
                if (double.TryParse(Console.ReadLine(), out double luongThuong)
                    && luongThuong >= 0)
                {
                    LuongThuong = luongThuong;
                    break;
                }
                else
                {
                    Console.WriteLine("Lương thưởng phải là số thực không âm.");
                }
            }

            while (true)
            {
                Console.Write("Nhập tiền phạt: ");
                if (double.TryParse(Console.ReadLine(), out double tienPhat)
                    && tienPhat >= 0)
                {
                    TienPhat = tienPhat;
                    break;
                }
                else
                {
                    Console.WriteLine("Tiền phạt phải là số thực không âm.");
                }
            }
        }

        public double TinhLuongThucLinh()
        {
            double luongThucLinh = LuongCung + LuongThuong - TienPhat;
            return luongThucLinh;
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Mã số giáo viên: {MaSoGV}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Quê quán: {QueQuan}");
            Console.WriteLine($"Lương cứng: {LuongCung}");
            Console.WriteLine($"Lương thưởng: {LuongThuong}");
            Console.WriteLine($"Tiền phạt: {TienPhat}");
            Console.WriteLine($"Lương thực lĩnh: {TinhLuongThucLinh()}");
        }
    }
}
