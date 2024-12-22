using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public class DoanThang : HinhHoc
    {
        public Diem A { get; set; } = new Diem();
        public Diem B { get; set; } = new Diem();
        public double DoDai { get; set; }

        public override void Nhap()
        {
            TenHinh = "Đoạn thẳng";
            Console.WriteLine("Nhập điểm A:");
            A.Nhap();
            Console.WriteLine("Nhập điểm B:");
            B.Nhap();
            DoDai = Diem.KhoangCach(A, B);
        }

        public override void Xuat()
        {
            Console.WriteLine($"Hình: {TenHinh}");
            Console.Write("Điểm A: ");
            A.Xuat();
            Console.Write("Điểm B: ");
            B.Xuat();
            Console.WriteLine($"Độ dài đoạn thẳng: {DoDai}");
        }
    }
}
