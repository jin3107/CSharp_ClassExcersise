using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang_DeB
{
    internal class MatHang
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private int donGia;

        public MatHang() { }

        public MatHang(int maHang, string tenHang, int soLuong, int donGia)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public int MaHang
        {
            get => maHang;
            set
            {
                if (value > 0)
                    maHang = value;
                else
                    throw new ArgumentException("Mã hàng số dương.");
            }
        }

        public string TenHang
        {
            get => tenHang;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tenHang = value.Trim();
                else
                    throw new ArgumentException("Tên hàng không được để trống.");
            }
        }

        public int SoLuong
        {
            get => soLuong;
            set
            {
                if (value > 0)
                    soLuong = value;
                else
                    throw new ArgumentException("Số lượng là số dương.");
            }
        }

        public int DonGia
        {
            get => donGia;
            set
            {
                if (value > 0) 
                    donGia = value;
                else
                    throw new ArgumentException("Đơn giá là số dương.");
            }
        }

        public int ThanhTien
        {
            get => SoLuong * DonGia;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập mã hàng: ");
            while (!int.TryParse(Console.ReadLine(), out maHang) || maHang <= 0)
            {
                Console.Write("Mã hàng phải là số nguyên dương. Nhập lại mã hàng: ");
            }

            Console.Write("Nhập tên hàng: ");
            tenHang = Console.ReadLine();

            Console.Write("Nhập số lượng: ");
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.Write("Số lượng phải là số nguyên dương. Nhập lại số lượng: ");
            }

            Console.Write("Nhập đơn giá: ");
            while (!int.TryParse(Console.ReadLine(), out donGia) || donGia <= 0)
            {
                Console.Write("Đơn giá phải là số nguyên dương. Nhập lại đơn giá: ");
            }
        }

        public override string ToString()
        {
            return $"{MaHang,-10} {TenHang,-15} {SoLuong,-10} {DonGia,-10} {ThanhTien,-10}";
        }
    }
}
