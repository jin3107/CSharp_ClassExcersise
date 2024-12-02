using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ThiSinhKhoiA : ThiSinh
    {
        public static string Mon_Toan = "Toán";
        public static string Mon_Ly = "Lý";
        public static string Mon_Hoa = "Hóa";
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public ThiSinhKhoiA() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Môn học: {Mon_Toan} - {Mon_Ly} - {Mon_Hoa}\n");

            Console.Write("Nhập điểm toán: ");
            DiemToan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm lý: ");
            DiemLy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm hóa: ");
            DiemHoa = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Điểm toán: {DiemToan}, Điểm lý: {DiemLy}, Điểm hóa: {DiemHoa}\n";
        }
    }
}
