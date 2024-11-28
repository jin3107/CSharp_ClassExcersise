using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Bao : TaiLieu
    {
        public int NgayPhatHanh { get; set; }

        public Bao() { }

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
