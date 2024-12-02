using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int MucUuTien { get; set; }

        public ThiSinh() { }

        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, int mucUuTien)
        {
            SoBaoDanh = soBaoDanh;
            HoTen = hoTen;
            DiaChi = diaChi;
            MucUuTien = mucUuTien;
        }

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

        public override string ToString()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            return $"Số báo danh: {SoBaoDanh}\n" +
                $"Họ tên: {HoTen}\n" +
                $"Địa chỉ: {DiaChi}\n" +
                $"Mức ưu tiên: {MucUuTien}\n";
        }
    }
}
