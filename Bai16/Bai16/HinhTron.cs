using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    public class HinhTron : HinhHoc
    {
        public Diem TamO { get; set; } = new Diem();
        public double BanKinh { get; set; }

        public HinhTron() { }

        public HinhTron(string tenHinh, Diem tamO, double banKinh) : base(tenHinh)
        {
            TamO = tamO;
            BanKinh = banKinh;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Hình tròn";
            Console.WriteLine("\nNhập tâm hình tròn: ");
            TamO.Nhap();

            Console.Write("Nhập bán kính: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double banKinh))
                {
                    BanKinh = banKinh;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai định dạng. Bán kính là số dương.\n");
                }
            }
        }

        public double ChuVi()
        {
            double chuVi = 2 * Math.PI * Math.Pow(BanKinh, 2);
            return chuVi;
        }

        public double DienTich()
        {
            double dienTich = Math.PI * Math.Pow(BanKinh, 2);
            return dienTich;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên hình: {TenHinh}");
            Console.Write($"Tâm O: ");
            TamO.Xuat();
            Console.WriteLine($"Bán kính: {BanKinh}");
            Console.WriteLine($"Chu vi: {ChuVi()}");
            Console.WriteLine($"Diện tích: {DienTich()}");
        }
    }
}
