using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class HinhTron : HinhHoc
    {
        public Diem TamO { get; set; } = new Diem();
        public double BanKinh { get; set; }

        public HinhTron() { }

        public HinhTron(Diem tamO, double banKinh)
        {
            TamO = tamO;
            BanKinh = banKinh;
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Hình tròn";
            Console.Write("Nhập tâm hình tròn: ");
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

        public double DienTichHinhTron()
        {
            double dienTich = Math.PI * Math.Pow(BanKinh, 2);
            return dienTich;
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên hình: {TenHinh}");
            Console.WriteLine($"Tâm O: ");
            TamO.Xuat();
            Console.WriteLine($"Bán kính: {BanKinh}");
            Console.WriteLine($"Diện tích: {DienTichHinhTron()}");
        }

    }
}
