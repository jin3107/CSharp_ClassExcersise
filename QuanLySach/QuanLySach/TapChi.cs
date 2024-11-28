using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class TapChi : TaiLieu
    {
        public string SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public TapChi() { }

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
