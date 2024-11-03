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

        public string SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public int ThangPhatHanh { get => thangPhatHanh; set => thangPhatHanh = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số phát hành: ");
            SoPhatHanh = Console.ReadLine();

            Console.Write("Nhập tháng phát hành: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());
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
