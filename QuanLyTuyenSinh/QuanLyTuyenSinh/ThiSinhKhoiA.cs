using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public class ThiSinhKhoiA : ThiSinh
    {
        public static string MON_TOAN = "Toán";
        public static string MON_LY = "Lý";
        public static string MON_HOA = "Hóa";

        public ThiSinhKhoiA() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Môn học: {MON_TOAN} - {MON_LY} - {MON_HOA}\n");
        }
    }
}
