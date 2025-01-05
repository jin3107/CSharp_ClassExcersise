using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    public class HinhChuNhat : HinhHoc
    {
        public Diem Dinh1 { get; set; } = new Diem();
        public Diem Dinh2 { get; set; } = new Diem();

        public HinhChuNhat() { }

        public HinhChuNhat(string tenHinh, Diem dinh1, Diem dinh2) : base(tenHinh)
        {
            Dinh1 = dinh1;
            Dinh2 = dinh2;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Hình chữ nhật";
            Console.WriteLine("\nNhập tọa độ đỉnh thứ nhất: ");
            Dinh1.Nhap();

            Console.WriteLine("\nNhập tọa độ đỉnh thứ hai: ");
            Dinh2.Nhap();
        }

        public double ChuVi()
        {
            double chieuDai = Math.Abs(Dinh1.X - Dinh2.X);
            double chieuRong = Math.Abs(Dinh1.Y - Dinh2.Y);
            double chuVi = (chieuDai + chieuRong) * 2;
            return chuVi;
        }

        public double DienTich()
        {
            double chieuDai = Math.Abs(Dinh1.X - Dinh2.X);
            double chieuRong = Math.Abs(Dinh1.Y - Dinh2.Y);
            double dienTich = chieuDai * chieuRong;
            return dienTich;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên hình: {TenHinh}");
            Console.Write("Đỉnh 1: ");
            Dinh1.Xuat();
            Console.Write("Đỉnh 2: ");
            Dinh2.Xuat();
            Console.WriteLine($"Chu vi hình chữ nhật: {ChuVi()}");
            Console.WriteLine($"Diện tích hình chữ nhật: {DienTich()}");
        }
    }
}
