using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    internal class ThiSinhKhoiB : ThiSinh
    {
        private static string MON_TOAN = "Toán";
        private static string MON_HOA = "Hóa";
        private static string MON_SINH = "Sinh";

        public ThiSinhKhoiB() { }

        public ThiSinhKhoiB(string soBaoDanh, string hoTen, string diaChi, int mucUuTien) : base(soBaoDanh, hoTen, diaChi, mucUuTien)
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Môn học: {MON_TOAN} - {MON_HOA} - {MON_SINH}\n");
        }
    }
}
