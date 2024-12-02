using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Lop { get; set; }

        public SinhVien()
        {
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên: ");
            HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập tuổi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhập lớp: ");
            Lop = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}\n" +
                $"Tuổi: {Tuoi}\n" +
                $"Lớp: {Lop}\n";
        }
    }
}
