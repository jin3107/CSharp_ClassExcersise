using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string NgheNghiep { get; set; }
        public string Cmnd { get; set; }

        public Nguoi() { }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0)
                {
                    Tuoi = tuoi;
                    break;
                }
                Console.WriteLine("Tuổi phải là một số nguyên dương.");
            }

            Console.Write("Nhập nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();

            Console.Write("Nhập CMND: ");
            Cmnd = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên: {HoTen}, Tuổi: {Tuoi}, Nghề ngiệp: {NgheNghiep}, CMND: {Cmnd}\n");
        }
    }
}
