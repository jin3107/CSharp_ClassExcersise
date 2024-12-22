using System;

namespace BaiTapHinhHoc
{
    public class Diem
    {
        public double x { get; set; }
        public double y { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public static double KhoangCach(Diem A, Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(B.y - A.y, 2));
        }
    }
}
