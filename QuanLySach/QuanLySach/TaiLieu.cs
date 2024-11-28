using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }

        public TaiLieu() { }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();

            Console.Write("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập số bản phát hành: ");
                if (int.TryParse(Console.ReadLine(), out int soBanPhatHanh) && soBanPhatHanh > 0)
                {
                    SoBanPhatHanh = soBanPhatHanh;
                    break;
                }
                Console.WriteLine("Số bản phát hành là số dương và lớn hơn 0.");
            }
        }

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Mã tài liệu: {MaTaiLieu}, Tên nhà xuất bản: {TenNhaXuatBan}, Số bản phát hành: {SoBanPhatHanh}");
        }
    }
}
