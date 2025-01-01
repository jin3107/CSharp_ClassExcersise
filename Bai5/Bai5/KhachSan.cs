using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class KhachSan
    {
        public List<Nguoi> DanhSachKhachHang { get; set; } = new List<Nguoi>();

        public KhachSan() { }

        public KhachSan(List<Nguoi> danhSachKhachHang)
        {
            DanhSachKhachHang = danhSachKhachHang;
        }

        public void ThemKhachHang()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n-- Nhập thông tin khách hàng --");
            Nguoi nguoi = new Nguoi();
            nguoi.Nhap();
            DanhSachKhachHang.Add(nguoi);
        }

        public void HienThiKhachHang()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            if (DanhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách khách hàng rỗng.");
                return;
            }

            Console.WriteLine("\nDanh sách khách hàng");
            foreach (var nguoi in DanhSachKhachHang)
            {
                int stt = 0;
                Console.WriteLine($"\n-- Khách hàng thứ {stt + 1} --");
                nguoi.Xuat();
            }
        }

        public void XoaKhachHang(string cmnd)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Nguoi nguoi = new Nguoi();
            nguoi = DanhSachKhachHang.Find(x => x.Cmnd == cmnd);
            if (nguoi != null)
            {
                DanhSachKhachHang.Remove(nguoi);
                Console.WriteLine("Xóa khách hàng thành công.");
            }
            else
                Console.WriteLine("Không tìm thấy khách hàng có số chứng minh nhân dân này");
        }

        public void TinhTienThuePhong(string cmnd)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Nguoi nguoi = new Nguoi();
            nguoi = DanhSachKhachHang.Find(x => x.Cmnd == cmnd);
            if (nguoi != null)
            {
                int tienThue = nguoi.PhongThue.GiaPhong * nguoi.PhongThue.SoNgayThue;
                Console.WriteLine($"Tiền thuê phòng của khách hàng {nguoi.HoTen} là: {tienThue}$");
            }
            else
                Console.WriteLine("Không tìm thấy khách hàng có số chứng minh nhân dân này");
        }
    }
}
