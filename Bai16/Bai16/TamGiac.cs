using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    public class TamGiac : HinhHoc
    {
        public Diem A { get; set; } = new Diem();
        public Diem B { get; set; } = new Diem();
        public Diem C { get; set; } = new Diem();

        public TamGiac() { }

        public TamGiac(string tenHinh, Diem a, Diem b, Diem c) : base(tenHinh)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Hình tam giác";
            Console.WriteLine("\nNhập tọa độ điểm A: ");
            A.Nhap();

            Console.WriteLine("\nNhập tọa độ điểm B: ");
            B.Nhap();

            Console.WriteLine("\nNhập tọa độ điểm C: ");
            C.Nhap();
        }

        public double ChuVi()
        {
            double AB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double AC = Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));
            double BC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));

            double chuVi = AB + AC + BC;
            return chuVi;
        }

        public double DienTich()
        {
            double AB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double AC = Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));
            double BC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));

            double nuaChuVi = (AB + AC + BC) / 2;
            double dienTich = Math.Sqrt(nuaChuVi * (nuaChuVi - AB) * (nuaChuVi - AC) * (nuaChuVi - BC));
            return dienTich;
        }

        public void KiemTra()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            double AB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double AC = Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));
            double BC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));

            if (Math.Pow(AB, 2) + Math.Pow(AC, 2) == Math.Pow(BC, 2) || Math.Pow(AC, 2) + Math.Pow(BC, 2) == Math.Pow(AB, 2)
                || Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2))
            {
                Console.WriteLine("--> Đây là tam giác vuông.");
                Console.WriteLine($"Chu vi tam giác: {ChuVi()}");
                Console.WriteLine($"Diện tích tam giác: {DienTich()}");
            }
            else if (AB == AC || AB == BC || BC == AC)
            {
                Console.WriteLine("--> Đây là tam giác cân.");
                Console.WriteLine($"Chu vi tam giác: {ChuVi()}");
                Console.WriteLine($"Diện tích tam giác: {DienTich()}");
            }
            else if (AB == BC && BC == AC)
            {
                Console.WriteLine("--> Đây là tam giác đều.");
                Console.WriteLine($"Chu vi tam giác: {ChuVi()}");
                Console.WriteLine($"Diện tích tam giác: {DienTich()}");
            }
            else if (AB + AC > BC && AB + BC > AC && AC + BC > AB && AB - AC < BC && AB - BC < AC && AC - BC < AB)
            {
                Console.WriteLine("--> Đây là tam giác thường.");
                Console.WriteLine($"Chu vi tam giác: {ChuVi()}");
                Console.WriteLine($"Diện tích tam giác: {DienTich()}");
            }
            else
                Console.WriteLine("--> Đây không phải là tam giác.");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Hình tam giác");
            Console.Write("Tọa độ điểm A: ");
            A.Xuat();

            Console.Write("Tọa độ điểm B: ");
            B.Xuat();

            Console.Write("Tọa độ điểm C: ");
            C.Xuat();

            KiemTra();
        }
    }
}
