using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class KhuPho
    {
        public List<HoGiaDinh> DanhSachHoGiaDinh { get; set; } = new List<HoGiaDinh>();

        public KhuPho(List<HoGiaDinh> danhSachHoGiaDinh)
        {
            DanhSachHoGiaDinh = danhSachHoGiaDinh;
        }
        public KhuPho()
        {
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int soLuong;
            Console.Write("Nhập số lượng hộ gia đình: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out soLuong) && soLuong > 0)
                    break;
                else
                    Console.WriteLine("Số lượng hộ gia đình phải là số nguyên dương.");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhập thông tin hộ gia đình thứ {i + 1}:");
                HoGiaDinh hoGiaDinh = new HoGiaDinh();
                hoGiaDinh.Nhap();
                DanhSachHoGiaDinh.Add(hoGiaDinh);
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Danh sách hộ gia đình trong khu phố:");
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                int thuTu = 0;
                Console.WriteLine($"Gia đình thứ {thuTu + 1}: ");
                hoGiaDinh.Xuat();
            }
        }
    }
}
