using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string NgheNghiep { get; set; }
        public string Cmnd { get; set; }

        public Nguoi()
        {
        }

        public Nguoi(string hoTen, int tuoi, string ngheNghiep, string cmnd)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            NgheNghiep = ngheNghiep;
            Cmnd = cmnd;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            while(true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0 && tuoi <= 100)
                {
                    Tuoi = tuoi;
                    break;
                }
                else
                    Console.WriteLine("Tuổi phải là số nguyên dương.\n");
            }

            Console.Write("Nhập nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();

            Console.Write("Nhập chứng minh nhân dân: ");
            Cmnd = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Nghề nghiệp: {NgheNghiep}");
            Console.WriteLine($"Chứng minh nhân dân: {Cmnd}");
        }
    }
}
