using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Phong
    {
        public string LoaiPhong { get; set; }
        public int GiaPhong { get; set; }
        public int SoNgayThue { get; set; }

        public Phong()
        {
        }

        public Phong(string loaiPhong, int giaPhong, int soNgayThue)
        {
            LoaiPhong = loaiPhong;
            GiaPhong = giaPhong;
            SoNgayThue = soNgayThue;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Write("Nhập số ngày thuê: ");
                if (int.TryParse(Console.ReadLine(), out int soNgayThue) && soNgayThue > 0 && soNgayThue <= 31)
                {
                    SoNgayThue = soNgayThue;
                    break;
                }
                else
                    Console.WriteLine("Số ngày thuê phải là số nguyên dương và không quá 31 ngày\n");
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Loại phòng: {LoaiPhong}, Giá phòng: {GiaPhong}");
            Console.WriteLine($"Số ngày thuê: {SoNgayThue}");
        }
    }   
}
