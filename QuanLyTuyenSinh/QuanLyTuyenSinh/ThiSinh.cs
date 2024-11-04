using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    internal class ThiSinh
    {
        private string soBaoDanh;
        private string hoTen;
        private string diaChi;
        private int mucUuTien;

        public ThiSinh() { }

        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, int mucUuTien)
        {
            this.SoBaoDanh = soBaoDanh;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.MucUuTien = mucUuTien;
        }

        public string SoBaoDanh 
        { 
            get => soBaoDanh; 
            set => soBaoDanh = value; 
        }

        public string HoTen 
        { 
            get => hoTen; 
            set => hoTen = value; 
        }

        public string DiaChi 
        { 
            get => diaChi; 
            set => diaChi = value; 
        }

        public int MucUuTien 
        { 
            get => mucUuTien;
            set => mucUuTien = value; 
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

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Số báo danh: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Mức ưu tiên: {MucUuTien}\n");
        }
    }
}
