using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public class HinhTron : HinhHoc
    {
        public Diem Tam { get; set; } = new Diem();
        public double BanKinh { get; set; }
        public double DienTich { get; set; }

        public override void Nhap()
        {
            TenHinh = "Hình tròn";
            Console.WriteLine("Nhập tọa độ tâm:");
            Tam.Nhap();
            Console.Write("Nhập bán kính: ");
            BanKinh = double.Parse(Console.ReadLine());
            DienTich = Math.PI * Math.Pow(BanKinh, 2);
        }

        public override void Xuat()
        {
            Console.WriteLine($"Hình: {TenHinh}");
            Console.Write("Tâm O: ");
            Tam.Xuat();
            Console.WriteLine($"Bán kính: {BanKinh}");
            Console.WriteLine($"Diện tích: {DienTich}");
        }
    }
}
