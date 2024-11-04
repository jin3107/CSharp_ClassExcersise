using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Bao : TaiLieu
    {
        private int ngayPhatHanh;

        public Bao()
        {
            
        }

        public Bao(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, int ngayPhatHanh) : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.NgayPhatHanh = ngayPhatHanh;
        }

        public int NgayPhatHanh 
        { 
            get => ngayPhatHanh; 
            set
            {
                if (value > 0 && value <= 31)
                    ngayPhatHanh = value;
                else
                    throw new ArgumentException("Ngày phát hành là số dương.");
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            { 
                Console.Write($"Nhập ngày phát hành: "); 
                if (int.TryParse(Console.ReadLine(), out int ngayPhatHanh) && ngayPhatHanh > 0 && ngayPhatHanh <= 31)
                {
                    NgayPhatHanh = ngayPhatHanh;
                    break;
                }
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}\n");
        }
    }
}
