using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class BTHinhHoc
    {
        public List<HinhHoc> DanhSachHinhHoc { get; set; } = new List<HinhHoc>();

        public BTHinhHoc() { }

        public BTHinhHoc(List<HinhHoc> danhSachHinhHoc)
        {
            DanhSachHinhHoc = danhSachHinhHoc;
        }

        public void ThemHinhHoc()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng hình học: ");
            int soLuong;
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.WriteLine("Số lượng phải là một số nguyên dương. Vui lòng nhập lại:");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhập hình thứ {i + 1}:");
                Console.WriteLine("1. Đoạn thẳng\n2. Hình tròn\n3. Hình chữ nhật\n4. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                int luaChon;
                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Nhập sai định dạng. Vui lòng nhập lại.\n");
                    i--; // Giảm i để nhập lại hình hiện tại
                    continue;
                }

                HinhHoc hinhHoc = null;
                switch (luaChon)
                {
                    case 1:
                        hinhHoc = new DoanThang();
                        break;
                    case 2:
                        hinhHoc = new HinhTron();
                        break;
                    case 3:
                        hinhHoc = new HinhChuNhat();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.\n");
                        i--;
                        continue;
                }

                try
                {
                    hinhHoc.Nhap();
                    DanhSachHinhHoc.Add(hinhHoc);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thêm hình học: {ex.Message}");
                    i--;
                }
            }
        }

        public void XuatDanhSachHinhHoc()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nKết quả");
            foreach (var hinhHoc in DanhSachHinhHoc)
            {
                hinhHoc.Xuat();
                Console.WriteLine("---------------------");
            }
        }
    }
}
