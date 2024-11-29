using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    public class MatHang
    {
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public MatHang() { }
        public int TienHang()
        {
            return SoLuong * DonGia;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập mã hàng: ");
            MaHang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên hàng: ");
            TenHang = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Xuat(int stt)
        {
            Console.WriteLine($"{stt, -5} {MaHang,-10} {TenHang,-20} {SoLuong,-10} {DonGia,-10} {TienHang(),-15}");
        }
    }
}
