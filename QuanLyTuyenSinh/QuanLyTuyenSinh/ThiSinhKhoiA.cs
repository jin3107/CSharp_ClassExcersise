using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    internal class ThiSinhKhoiA : ThiSinh
    {
        private static string MON_TOAN = "Toán";
        private static string MON_LY = "Lý";
        private static string MON_HOA = "Hóa";

        public ThiSinhKhoiA(string soBaoDanh, string hoTen, string diaChi, int mucUuTien) : base(soBaoDanh, hoTen, diaChi, mucUuTien)
        {
        }

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
