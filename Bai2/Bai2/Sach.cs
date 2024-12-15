using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public Sach() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập tên tác giả: ");
            TenTacGia = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập số trang: ");
            SoTrang = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Tên tác giả: {TenTacGia}\n" +
                $"Số trang: {SoTrang}\n";
        }
    }
}
