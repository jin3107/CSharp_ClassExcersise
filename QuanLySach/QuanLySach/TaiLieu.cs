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

        public string MaTaiLieu 
        { 
            get => maTaiLieu; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    maTaiLieu = value.Trim();
                else
                    throw new ArgumentException("Mã tài liệu không được để trống.");
            }
        }

        public string TenNhaXuatBan 
        {
            get => tenNhaXuatBan; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tenNhaXuatBan = value.Trim();
                else
                    throw new ArgumentException("Tên nhà xuất bản không được để trống.");
            }
        }

        public int SoBanPhatHanh 
        { 
            get => soBanPhatHanh;
            set
            {
                if (value > 0)
                    soBanPhatHanh = value;
                else
                    throw new ArgumentException("Số bản phát hành là số dương và lớn hơn 0.");
            }
        }

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
