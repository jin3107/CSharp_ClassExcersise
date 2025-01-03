using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class DoanThang : HinhHoc
    {
        public Diem A { get; set; } = new Diem();
        public Diem B { get; set; } = new Diem();

        public DoanThang() { }

        public DoanThang(Diem a, Diem b)
        {
            A = a;
            B = b;
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Đoạn thẳng";
            Console.WriteLine("\nNhập điểm A: ");
            A.Nhap();

            Console.WriteLine("\nNhập điểm B: ");
            B.Nhap();
        }

        public double DoDaiDoanThang()
        {
            double khoangCach = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return khoangCach;
        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Điểm A: ");
            A.Xuat();
            Console.Write("Điểm B: ");
            B.Xuat();
            Console.WriteLine($"Độ dài đoạn thẳng : {DoDaiDoanThang()}");
        }
    }
}
