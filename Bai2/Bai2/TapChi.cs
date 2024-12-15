using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public TapChi() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số phát hành: ");
            SoPhatHanh = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tháng phát hành: ");
            ThangPhatHanh = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Số phát hành: {SoBanPhatHanh}\n" +
                $"Tháng phát hành: {ThangPhatHanh}\n";
        }
    }
}
