using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public class ThiSinhKhoiC : ThiSinh
    {
        public static string MON_VAN = "Văn";
        public static string MON_SU = "Sử";
        public static string MON_DIA = "Địa";

        public ThiSinhKhoiC() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Môn học: {MON_VAN} - {MON_SU} - {MON_DIA}\n");
        }
    }
}
