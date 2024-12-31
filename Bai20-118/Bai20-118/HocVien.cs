using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_118
{
    public class HocVien
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public Lop lop { get; set; } = new Lop();
        public MonHoc diemMonHoc { get; set; } = new MonHoc();

        public HocVien() { }

        public HocVien(string hoTen, int namSinh, Lop lop, MonHoc diemMonHoc)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.lop = lop;
            this.diemMonHoc = diemMonHoc;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            lop.Nhap();
            diemMonHoc.Nhap();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"\nHọ tên: {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}");

            lop.Xuat();
            diemMonHoc.Xuat();
        }
    }
}
