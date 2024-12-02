using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ThiSinhKhoiC : ThiSinh
    {
        public static string Mon_Van = "Văn";
        public static string Mon_Su = "Sử";
        public static string Mon_Dia = "Địa";
        public double DiemVan { get; set; }
        public double DiemSu { get; set; }
        public double DiemDia { get; set; }

        public ThiSinhKhoiC() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Môn học: {Mon_Van} - {Mon_Su} - {Mon_Dia}\n");

            Console.Write("Nhập điểm văn: ");
            DiemVan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm sử: ");
            DiemSu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm địa: ");
            DiemDia = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Điểm văn: {DiemVan}, Điểm sử: {DiemSu}, Điểm địa: {DiemDia}\n";
        }
    }
}
