using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class QuanLyTuyenSinh
    {
        public QuanLyTuyenSinh(List<ThiSinh> danhSachThiSinh)
        {
            DanhSachThiSinh = danhSachThiSinh;
        }

        public List<ThiSinh> DanhSachThiSinh { get; set; } = new List<ThiSinh>();

        public void ThemThiSinh()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Nhập thông tin thí sinh --");
            int loai;
            while (true)
            {
                Console.WriteLine("1. Khối A\n2. Khối B\n3. Khối C");
                Console.Write("Lựa chọn của bạn: ");
                if (int.TryParse(Console.ReadLine(), out loai) && loai >= 1 && loai <= 3)
                    break;
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn 1, 2 hoặc 3.");
            }

            ThiSinh thiSinh;
            switch(loai)
            {
                case 1: 
                    thiSinh = new ThiSinhKhoiA(); break;
                case 2:
                    thiSinh = new ThiSinhKhoiB(); break;
                case 3:
                    thiSinh = new ThiSinhKhoiC(); break;
                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng nhập lại!");
                    return;
            }

            try
            {
                thiSinh.Nhap();
                DanhSachThiSinh.Add(thiSinh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm Thí sinh: {ex.Message}");
            }
        }

        public void HienThiThiSinh()
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
                Console.WriteLine(thiSinh.ToString());
            }
        }

        public void TimKiemTheoSBD(string soBaoDanh)
        {
            ThiSinh thiSinh = DanhSachThiSinh.Where(ts => ts.SoBaoDanh == soBaoDanh).FirstOrDefault();
            if (thiSinh != null)
            {
                Console.WriteLine($"\n--> Thông tin thí sinh có số báo danh '{soBaoDanh}'");
                Console.WriteLine(thiSinh.ToString());
            }
            else
            {
                Console.WriteLine($"\n--> Không tìm thấy thì sinh có số báo danh '{soBaoDanh}'");
                return;
            }
        }
    }
}
