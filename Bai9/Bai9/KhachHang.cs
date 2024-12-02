using System;
using System.Text;

namespace Bai9
{
    public class KhachHang
    {
        public string HoTen { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongToDien { get; set; }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên chủ hộ: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();

            Console.Write("Nhập mã số công tơ điện: ");
            MaSoCongToDien = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}\n" +
                $"Số nhà: {SoNha}\n" +
                $"Mã số công tơ điện: {MaSoCongToDien}\n";
        }
    }
}
