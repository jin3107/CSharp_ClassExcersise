using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class HocSinh
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string QueQuan { get; set; }
        public string TenLop { get; set; }

        public HocSinh()
        {
        }

        public HocSinh(string hoTen, int tuoi, string queQuan, string tenLop)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            QueQuan = queQuan;
            TenLop = tenLop;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

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
                    Console.WriteLine("Nhập tuổi không đúng định dạng. Nhập lại\n");
            }

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            Console.Write("Nhập tên lớp của học sinh: ");
            TenLop = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Quê quán: {QueQuan}");
            Console.WriteLine($"Tên lớp của học sinh: {TenLop}");
        }
    }
}
