using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int MucUuTien { get; set; }

        public ThiSinh() { }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số báo danh: ");
            SoBaoDanh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập họ tên: ");
            HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập mức ưu tiên: ");
            MucUuTien = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Số báo danh: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Mức ưu tiên: {MucUuTien}\n");
        }
    }
}
