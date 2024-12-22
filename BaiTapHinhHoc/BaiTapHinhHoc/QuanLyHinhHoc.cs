using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public class QuanLyHinhHoc
    {
        private List<HinhHoc> danhSachHinh = new List<HinhHoc>();

        public void NhapDanhSachHinh()
        {
            Console.Write("Nhập số lượng hình học: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập hình thứ {i + 1}: ");
                Console.WriteLine("1. Đoạn thẳng\n2. Hình tròn\n3. Hình chữ nhật\n4. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                int luaChon = int.Parse(Console.ReadLine());

                HinhHoc hinh = null;
                switch (luaChon)
                {
                    case 1:
                        hinh = new DoanThang();
                        break;
                    case 2:
                        hinh = new HinhTron();
                        break;
                    case 3:
                        hinh = new HinhChuNhat();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

                if (hinh != null)
                {
                    hinh.Nhap();
                    danhSachHinh.Add(hinh);
                }
            }
        }

        public void XuatDanhSachHinh()
        {
            Console.WriteLine("\nKết quả:");
            foreach (var hinh in danhSachHinh)
            {
                hinh.Xuat();
                Console.WriteLine("------------------");
            }
        }
    }
}
