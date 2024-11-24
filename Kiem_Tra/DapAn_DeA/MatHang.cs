using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    internal class MatHang
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private int donGia;

        public MatHang(int maHang, string tenHang, int soLuong, int donGia)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public MatHang()
        {
            
        }

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập mã hàng: ");
            MaHang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên hàng: ");
            TenHang = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = Convert.ToInt32(Console.ReadLine());
        }
        
        public int TienHang()
        {
            return SoLuong * DonGia;
        }

        public void Xuat()
        {
            Console.WriteLine($"{MaHang,-10} {TenHang,-20} {SoLuong,-10} {DonGia,-10} {TienHang(),-15}");
        }
    }
}
