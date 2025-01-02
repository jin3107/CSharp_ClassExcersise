using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class DoanThang : HinhHoc
    {
        public Diem A { get; set; } = new Diem();
        public Diem B { get; set; } = new Diem();
        public double DoDai { get; set; }

        public DoanThang() { }

        public DoanThang(Diem a, Diem b, double doDai)
        {
            A = a;
            B = b;
            DoDai = doDai;
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Đoạn thẳng";
            Console.WriteLine("Nhập điểm A: ");
            A.Nhap();

            Console.WriteLine("Nhập điểm B: ");
            B.Nhap();

            DoDai = Diem.KhoangCach(A, B);
        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Điểm A: ");
            A.Xuat();
            Console.Write("Điểm B: ");
            B.Xuat();
            Console.WriteLine($"Độ dài đoạn thẳng : {DoDai}");
        }
    }
}
