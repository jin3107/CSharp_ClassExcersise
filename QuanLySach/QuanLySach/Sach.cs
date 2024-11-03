using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Sach : TaiLieu
    {
        private string tenTacGia;
        private int soTrang;

        public Sach()
        {
            
        }

        public Sach(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string tenTacGia, int soTrang) : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.TenTacGia = tenTacGia;
            this.SoTrang = soTrang;
        }

        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên tác giả: ");
            TenTacGia = Console.ReadLine();

            Console.Write("Nhập số trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên tác giả: {TenTacGia}, Số trang: {SoTrang}\n");
        }
    }
}
