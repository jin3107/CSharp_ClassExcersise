using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public CanBo()
        {
        }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên: ");
            HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập tuổi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập giới tính: ");
            GioiTinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}\n" +
                $"Tuổi: {Tuoi}\n" +
                $"Giới tính: {GioiTinh}\n" +
                $"Địa chỉ: {DiaChi}\n";
        }
    }
}
