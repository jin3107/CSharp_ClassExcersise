using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class QuanLyHoSoHS
    {
        public List<HocSinh> DanhSachHocSinh { get; set; } = new List<HocSinh>();

        public QuanLyHoSoHS(List<HocSinh> danhSachHocSinh)
        {
            DanhSachHocSinh = danhSachHocSinh;
        }

        public QuanLyHoSoHS()
        {
        }

        public void ThemHocSinh()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Nhập thông tin cho học sinh --");
            try
            {
                HocSinh hs = new HocSinh();
                hs.Nhap();
                DanhSachHocSinh.Add(hs);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi khi thêm học sinh: {e.Message}");
            }
        }

        public void HienThiHocSinh20Tuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Danh sách học sinh 20 tuổi --");
            int thu = 0;
            var hocSinhList = DanhSachHocSinh.FindAll(hs => hs.Tuoi == 20);
            if (hocSinhList.Any())
            {
                foreach (var hocSinh in hocSinhList)
                {
                    Console.WriteLine($"\n- Học sinh thứ {thu + 1}:");
                    hocSinh.Xuat();
                    thu++;
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào 20 tuổi");
            }
        }

        public void HienThiHocSinh23TuoiDaNang()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Danh sách học sinh 23 tuổi và quê ở Đà Nẵng --");
            int thu = 0;
            var hocSinhList = DanhSachHocSinh.FindAll(hs => hs.Tuoi == 23
                && string.Equals(hs.QueQuan, "Đà Nẵng", StringComparison.OrdinalIgnoreCase));
            if (hocSinhList.Any())
            {
                foreach (var hocSinh in hocSinhList)
                {
                    Console.WriteLine($"\n- Học sinh thứ {thu + 1}:");
                    hocSinh.Xuat();
                    thu++;
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào 23 tuổi và quê ở Đà Nẵng");
            }
        }

        public void HienThiDanhSachHocSinh()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Danh sách học sinh --");
            if (DanhSachHocSinh.Count == 0)
                Console.WriteLine("Danh sách học sinh rỗng");

            int level = 0;
            foreach (var hocSinh in DanhSachHocSinh)
            {
                Console.WriteLine($"\n- Học sinh thứ {level + 1}");
                hocSinh.Xuat();
                level++;
            }
        }
    }
}
