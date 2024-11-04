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

        public string TenTacGia 
        { 
            get => tenTacGia; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tenTacGia = value.Trim();
                else
                    throw new ArgumentException("Tên tác giả không được để trống.");
            }
        }

        public int SoTrang 
        { 
            get => soTrang; 
            set
            {
                if (value > 0)
                    soTrang = value;
                else
                    throw new ArgumentException("Số trang là số dương.");
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên tác giả: ");
            TenTacGia = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập số trang: ");
                if (int.TryParse(Console.ReadLine(), out int soTrang) && soTrang > 0)
                {
                    SoTrang = soTrang;
                    break;
                }
                Console.WriteLine("Số trang là số dương.");
            }
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
