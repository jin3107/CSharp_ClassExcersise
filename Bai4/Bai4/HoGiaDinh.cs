using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class HoGiaDinh
    {
        public string SoNha { get; set; }
        public List<Nguoi> DanhSachNguoi { get; set; } = new List<Nguoi>();

        public HoGiaDinh()
        {
        }

        public HoGiaDinh(string soNha, List<Nguoi> danhSachNguoi)
        {
            SoNha = soNha;
            DanhSachNguoi = danhSachNguoi;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            int soLuong;
            Console.Write("Nhập số lượng thành viên trong gia đình: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out soLuong) && soLuong > 0)
                    break;
                else
                    Console.WriteLine("Số lượng thành viên phải là số nguyên dương.");
            }

            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhập thông tin thành viên thứ {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                DanhSachNguoi.Add(nguoi);
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Số nhà: {SoNha}");
            Console.WriteLine("Danh sách thành viên trong gia đình:");
            foreach (var nguoi in DanhSachNguoi)
            {
                nguoi.Xuat();
            }
        }
    }
}
