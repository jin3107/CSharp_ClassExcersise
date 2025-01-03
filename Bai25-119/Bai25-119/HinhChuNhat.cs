using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class HinhChuNhat : HinhHoc
    {
        public Diem Dinh1 { get; set; } = new Diem();
        public Diem Dinh2 { get; set; } = new Diem();

        public HinhChuNhat() { }

        public HinhChuNhat(Diem dinh1, Diem dinh2)
        {
            Dinh1 = dinh1;
            Dinh2 = dinh2;
        }

        public override void Nhap()
        {
            TenHinh = "Hình chữ nhật";
            Console.WriteLine("Nhập tọa độ đỉnh thứ nhất: ");
            Dinh1.Nhap();

            Console.WriteLine("Nhập tọa độ đỉnh thứ hai: ");
            Dinh2.Nhap();
        }

        public double DienTichHinhChuNhat()
        {
            double chieuDai = Math.Abs(Dinh1.X - Dinh2.X);
            double chieuRong = Math.Abs(Dinh1.Y - Dinh2.Y);
            double dienTich = chieuDai * chieuRong;
            return dienTich;
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên hình: {TenHinh}");
            Console.WriteLine("Đỉnh 1: ");
            Dinh1.Xuat();
            Console.WriteLine("Đỉnh 2: ");
            Dinh2.Xuat();
            Console.WriteLine($"Diện thích hình chữ nhật: {DienTichHinhChuNhat()}");
        }
    }
}
