using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class TapChi : TaiLieu
    {
        private string soPhatHanh;
        private int thangPhatHanh;

        public TapChi()
        {
            
        }

        public TapChi(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string soPhatHanh, int thangPhatHanh) : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.SoPhatHanh = soPhatHanh;
            this.ThangPhatHanh = thangPhatHanh;
        }

        public string SoPhatHanh 
        { 
            get => soPhatHanh; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    SoPhatHanh = value.Trim();
                else
                    throw new ArgumentException("Số phát hành không được để trống.");
            }
        }

        public int ThangPhatHanh 
        { 
            get => thangPhatHanh; 
            set
            {
                if (value > 0 && value <= 12)
                    thangPhatHanh = value;
                else
                    throw new ArgumentException("Tháng phát hành là số dương.");
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số phát hành: ");
            SoPhatHanh = Console.ReadLine();

            while (true)
            { 
                Console.Write("Nhập tháng phát hành: "); 
                if (int.TryParse(Console.ReadLine(), out int thangPhatHanh) && thangPhatHanh > 0 && thangPhatHanh <= 12)
                {
                    ThangPhatHanh = thangPhatHanh;
                    break;
                }
                Console.WriteLine("Tháng phát hành là số dương.");
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Số phát hành: {SoBanPhatHanh}, Tháng phát hành: {ThangPhatHanh}\n");
        }
    }
}
