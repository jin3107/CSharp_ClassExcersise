using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_118
{
    public class TamGiac
    {
        public Diem A { get; set; } = new Diem();
        public Diem B { get; set; } = new Diem();
        public Diem C { get; set; } = new Diem();

        public TamGiac(Diem a, Diem b, Diem c)
        {
            A = a;
            B = b;
            C = c;
        }

        public TamGiac()
        {
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n- Nhập tọa độ 3 đỉnh của tam giác: ");
            Console.WriteLine("\nNhập tọa độ điểm A: ");
            A.Nhap();
            Console.WriteLine("\nNhập tọa độ điểm B: ");
            B.Nhap();
            Console.WriteLine("\nNhập tọa độ điểm C: ");
            C.Nhap();
        }

        public void Xuat()
        {
            Console.Write("\nA");
            A.Xuat();
            Console.Write("\nB");
            B.Xuat();
            Console.Write("\nC");
            C.Xuat();
        }

        public void ToaDoTrongTam()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double x = (A.X + B.X + C.X) / 3;
            double y = (A.Y + B.Y + C.Y) / 3;
            Console.WriteLine($"\nTọa độ trọng tâm G({x}; {y})");
        }

        public void ToaDoTrucTam()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a = C.X - B.X;
            double b = C.Y - B.Y;
            double c = C.X - A.X;
            double d = C.Y - A.Y;

            double D = 2 * (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y));

            if (D == 0)
            {
                Console.WriteLine("Ba điểm thẳng hàng, không có trực tâm của tam giác.");
                return;
            }

            double yH = (c * a * A.X + c * b * A.Y - a * c * B.X - a * d * B.Y) / (c * b - a * d);
            double xH = (a * A.X + b * A.Y - b * yH) / (a);

            Console.WriteLine($"Tọa độ trực tâm H({xH}; {yH})");
        }

        public void ToaDoTamVongTronNgoaiTiep()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double D = 2 * (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y));

            if (D == 0)
            {
                Console.WriteLine("Ba điểm thẳng hàng, không có đường tròn ngoại tiếp.");
                return;
            }

            double A1 = A.X * A.X + A.Y * A.Y;
            double B1 = B.X * B.X + B.Y * B.Y;
            double C1 = C.X * C.X + C.Y * C.Y;

            double xI = (A1 * (B.Y - C.Y) + B1 * (C.Y - A.Y) + C1 * (A.Y - B.Y)) / D;
            double yI = (A1 * (C.X - B.X) + B1 * (A.X - C.X) + C1 * (B.X - A.X)) / D;

            Console.WriteLine($"Tọa độ tâm đường tròn ngoại tiếp tam giác I({xI}; {yI})");
        }

    }
}
