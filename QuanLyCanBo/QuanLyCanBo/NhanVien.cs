using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    public class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien() { }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Nhap();
            Console.Write("Nhập công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Xuat();
            Console.WriteLine($"Công việc: {CongViec}\n");
        }
    }
}
