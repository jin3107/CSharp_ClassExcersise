using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    public class GiaDinh
    {
        public List<Nguoi> HoGiaDinh { get; set; } = new List<Nguoi>();
        public string DiaChi { get; set; }

        public GiaDinh() { }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập địa chỉ gia đình: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhập số lượng thành viên trong gia đình: ");
            int soLuong;
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.WriteLine("Số lượng thành viên phải là số nguyên dương.");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin cho thành viên thứ {i + 1} ---");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                HoGiaDinh.Add(nguoi);
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Địa chỉ gia đình: {DiaChi}");
            Console.WriteLine("- Danh sách thành viên -");

            foreach (Nguoi nguoi in HoGiaDinh)
            {
                nguoi.Xuat();
            }
        }
    }
}
