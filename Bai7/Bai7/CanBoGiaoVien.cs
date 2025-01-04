using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class CanBoGiaoVien
    {
        public List<Nguoi> DanhSachCanBoGiaoVien { get; set; } = new List<Nguoi>();

        public CanBoGiaoVien() { }

        public CanBoGiaoVien(List<Nguoi> danhSachCanBoGiaoVien)
        {
            DanhSachCanBoGiaoVien = danhSachCanBoGiaoVien;
        }

        public void ThemCanBoGiaoVien()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n-- Nhập thông tin cán bộ giáo viên --");
            Nguoi nguoi = new Nguoi();
            nguoi.Nhap();
            DanhSachCanBoGiaoVien.Add(nguoi);
        }

        public void XoaCanBoGiaoVien()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n-- Xóa thông tin cán bộ giáo viên --");
            Console.Write("Nhập mã số giáo viên cần xóa: ");
            string maSoGV = Console.ReadLine();
            Nguoi nguoi = DanhSachCanBoGiaoVien.Find(x => x.MaSoGV == maSoGV);
            if (nguoi != null)
            {
                DanhSachCanBoGiaoVien.Remove(nguoi);
                Console.WriteLine("Đã xóa thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã số giáo viên cần xóa.");
            }
        }

        public void HienThiGiaoVien()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n-- Danh sách cán bộ giáo viên --");
            if (DanhSachCanBoGiaoVien.Count == 0)
            {
                Console.WriteLine("Danh sách cán bộ giáo viên rỗng.");
                return;
            }
            int thuTu = 0;
            foreach (var giaoVien in DanhSachCanBoGiaoVien)
            {
                Console.WriteLine($"\n - Giáo viên thứ {thuTu + 1}:");
                giaoVien.Xuat();
            }
        }
    }
}
