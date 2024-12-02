using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ThiSinhKhoiB : ThiSinh
    {
        public static string Mon_Toan = "Toán";
        public static string Mon_Hoa = "Hóa";
        public static string Mon_Sinh = "Sinh";
        public double DiemToan { get; set; }
        public double DiemHoa { get; set; }
        public double DiemSinh { get; set; }

        public ThiSinhKhoiB() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Môn học: {Mon_Toan} - {Mon_Hoa} - {Mon_Sinh}\n");

            Console.Write("Nhập điểm toán: ");
            DiemToan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm hóa: ");
            DiemHoa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm sinh: ");
            DiemSinh = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Điểm toán: {DiemToan}, Điểm hóa: {DiemHoa}, Điểm sinh: {DiemSinh}\n";
        }
    }
}
