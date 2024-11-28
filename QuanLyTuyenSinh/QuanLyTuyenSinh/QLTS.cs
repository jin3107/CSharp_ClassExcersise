using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public class QLTS
    {
        public List<ThiSinh> DanhSachThiSinh { get; set; } = new List<ThiSinh>();

        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập thông tin thí sinh.");
            int loai;

            while (true)
            {
                Console.WriteLine("1. Khối A, 2. Khối B, 3. Khối C");
                Console.Write("Lựa chọn của bạn: ");
                if (int.TryParse(Console.ReadLine(), out loai) && loai >= 1 && loai <= 3)
                {
                    break;
                }
                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại 1, 2 hoặc 3.");
            }

            ThiSinh thiSinh;
            switch (loai)
            {
                case 1:
                    thiSinh = new ThiSinhKhoiA(); break;
                case 2:
                    thiSinh = new ThiSinhKhoiB(); break;
                case 3:
                    thiSinh = new ThiSinhKhoiC(); break;
                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ."); return;
            }

            try
            {
                thiSinh.Nhap();
                DanhSachThiSinh.Add(thiSinh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi nhập dữ liệu: {ex.Message}");
            }
        }

        public void Output()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (DanhSachThiSinh.Count() == 0)
            {
                Console.WriteLine("\nKhông có thí sinh nào trong danh sách.");
                return;
            }

            Console.WriteLine("\n--- Thông tin thí sinh ---");
            foreach (var thiSinh in DanhSachThiSinh)
            {
                thiSinh.Xuat();
            }
        }

        public ThiSinh Search(string soBaoDanh)
        {
            return DanhSachThiSinh.Find(ts => ts.SoBaoDanh == soBaoDanh);
        }
    }
}
