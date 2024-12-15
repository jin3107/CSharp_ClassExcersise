using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Bao : TaiLieu
    {
        public int NgayPhatHanh { get; set; }

        public Bao() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngày phát hành: ");
            NgayPhatHanh = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Ngày phát hành: {NgayPhatHanh}\n";
        }
    }
}
