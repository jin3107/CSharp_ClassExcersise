using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public class HinhChuNhat : HinhHoc
    {
        public Diem Dinh1 { get; set; } = new Diem();
        public Diem Dinh2 { get; set; } = new Diem();
        public double DienTich { get; set; }

        public override void Nhap()
        {
            TenHinh = "Hình chữ nhật";
            Console.WriteLine("Nhập tọa độ đỉnh thứ nhất:");
            Dinh1.Nhap();
            Console.WriteLine("Nhập tọa độ đỉnh thứ hai:");
            Dinh2.Nhap();

            double chieuDai = Math.Abs(Dinh1.x - Dinh2.x);
            double chieuRong = Math.Abs(Dinh1.y - Dinh2.y);
            DienTich = chieuDai * chieuRong;
        }

        public override void Xuat()
        {
            Console.WriteLine($"Hình: {TenHinh}");
            Console.Write("Đỉnh 1: ");
            Dinh1.Xuat();
            Console.Write("Đỉnh 2: ");
            Dinh2.Xuat();
            Console.WriteLine($"Diện tích: {DienTich}");
        }
    }
}

