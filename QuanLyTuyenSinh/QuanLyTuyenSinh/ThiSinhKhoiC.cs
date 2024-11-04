using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    internal class ThiSinhKhoiC : ThiSinh
    {
        private static string MON_VAN = "Văn";
        private static string MON_SU = "Sử";
        private static string MON_DIA = "Địa";

        public ThiSinhKhoiC() { }

        public ThiSinhKhoiC(string soBaoDanh, string hoTen, string diaChi, int mucUuTien) : base(soBaoDanh, hoTen, diaChi, mucUuTien)
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Môn học: {MON_VAN} - {MON_SU} - {MON_DIA}\n");
        }
    }
}
