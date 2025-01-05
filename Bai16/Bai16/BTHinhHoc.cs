using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
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

            int soLuong;
            Console.Write("Nhập số lượng hình học: ");
            while(!int.TryParse(Console.ReadLine(), out soLuong))
            {
                Console.WriteLine("Số lượng không hợp lệ. Nhập lại!\n");
                Console.Write("Nhập số lượng hình học: ");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\n-- Nhập hình thứ {i + 1} --");
                Console.WriteLine("1. Hình tròn\n2. Hình chữ nhật\n3. Hình tam giác\n4. Thoát");
                
                Console.Write("Lựa chọn của bạn: ");
                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại!");
                    i--;
                    continue;
                }

                HinhHoc hinhHoc;
                switch(luaChon)
                {
                    case 1:
                        hinhHoc = new HinhTron();
                        break;
                    case 2:
                        hinhHoc = new HinhChuNhat();
                        break;
                    case 3:
                        hinhHoc = new TamGiac();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Không hợp lệ. Nhập lại!");
                        i--;
                        continue;
                }

                hinhHoc.Nhap();
                DanhSachHinhHoc.Add(hinhHoc);
            }
        }

        public void HienThiHinhHoc()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Thông tin danh sách hình học --");
            if (DanhSachHinhHoc.Count == 0)
                Console.WriteLine("\nDanh sách rỗng.");
            foreach (var hinhHoc in DanhSachHinhHoc)
            {
                hinhHoc.Xuat();
            }
        }
    }
}
