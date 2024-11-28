using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public Sach() { }

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
