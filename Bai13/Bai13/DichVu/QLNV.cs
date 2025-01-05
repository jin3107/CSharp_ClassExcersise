using Bai13.ThucThe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.DichVu
{
    public class QLNV
    {
        public List<NhanVien> DanhSachNhanVien { get; set; } = new List<NhanVien>();

        public QLNV() { }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Nhập thông tin nhân viên --");
            if (nhanVien != null)
            {
                DanhSachNhanVien.Add(nhanVien);
                Console.WriteLine("Thêm nhân viên thành công!");
            }
        }

        public void SuaNhanVien()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập mã nhân viên cần chỉnh sửa: ");
            string maNhanVien = Console.ReadLine();
            NhanVien nhanVien = DanhSachNhanVien.Find(nv => nv.MaNhanVien == maNhanVien);
            if (nhanVien != null)
            {
                Console.WriteLine("Nhập họ tên mới: ");
                nhanVien.HoTen = Console.ReadLine();

                Console.WriteLine("Nhập ngày sinh mới (dd/MM/yyyy): ");
                nhanVien.NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.WriteLine("Nhập số điện thoại mới: ");
                nhanVien.SoDienThoai = Console.ReadLine();

                Console.WriteLine("Nhập email mới: ");
                nhanVien.Email = Console.ReadLine();

                Console.WriteLine("Chỉnh sửa thông tin nhân viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên với mã đã nhập.");
            }
        }

        public void XoaNhanVien()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập mã nhân viên cần xóa: ");
            string maNhanVien = Console.ReadLine();
            NhanVien nhanVien = DanhSachNhanVien.Find(nv => nv.MaNhanVien == maNhanVien);
            if (nhanVien != null)
            {
                DanhSachNhanVien.Remove(nhanVien);
                Console.WriteLine("Xóa nhân viên thành công!");
            }
            else
                Console.WriteLine("Không tìm thấy nhân viên với mã đã nhập");
        }
    }
}
