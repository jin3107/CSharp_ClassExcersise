using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    public class CanBo
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo() { }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên: ");
            Ten = Console.ReadLine();

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

            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"\nTên: {Ten}, Tuổi: {Tuoi}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
