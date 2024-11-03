using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class TaiLieu
    {
        private string maTaiLieu;
        private string tenNhaXuatBan;
        private int soBanPhatHanh;

        public TaiLieu()
        {
            
        }

        public TaiLieu(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh)
        {
            this.MaTaiLieu = maTaiLieu;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.SoBanPhatHanh = soBanPhatHanh;
        }

        public string MaTaiLieu { get => maTaiLieu; set => maTaiLieu = value; }
        public string TenNhaXuatBan { get => tenNhaXuatBan; set => tenNhaXuatBan = value; }
        public int SoBanPhatHanh { get => soBanPhatHanh; set => soBanPhatHanh = value; }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();

            Console.Write("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Console.ReadLine();

            Console.Write("Nhập số bản phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Mã tài liệu: {MaTaiLieu}, Tên nhà xuất bản: {TenNhaXuatBan}, Số bản phát hành: {SoBanPhatHanh}");
        }
    }
}
