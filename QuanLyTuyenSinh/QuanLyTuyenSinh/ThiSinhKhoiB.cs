using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public class ThiSinhKhoiB : ThiSinh
    {
        public static string MON_TOAN = "Toán";
        public static string MON_HOA = "Hóa";
        public static string MON_SINH = "Sinh";

        public ThiSinhKhoiB() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Môn học: {MON_TOAN} - {MON_HOA} - {MON_SINH}\n");
        }
    }
}
