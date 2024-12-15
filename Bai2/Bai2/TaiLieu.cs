using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
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
            MaTaiLieu = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập số bản phát hành: ");
            SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Mã tài liệu: {MaTaiLieu}\n" +
                $"Tên nhà xuất bản: {TenNhaXuatBan}\n" +
                $"Số bản phát hành: {SoBanPhatHanh}\n";
        }
    }
}
