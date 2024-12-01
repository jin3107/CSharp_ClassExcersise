using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập công việc: ");
            CongViec = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Công việc: {CongViec}\n";
        }
    }
}
