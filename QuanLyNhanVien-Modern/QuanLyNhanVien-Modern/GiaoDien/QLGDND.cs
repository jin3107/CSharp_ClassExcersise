using QuanLyNhanVien_Modern.DichVu;
using QuanLyNhanVien_Modern.ThucThe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.GiaoDien
{
    internal class QLGDND
    {
        private QLNV quanLyNhanVien = new QLNV();

        public QLGDND()
        {
            
        }

        public QLGDND(QLNV quanLyNhanVien)
        {
            this.QuanLyNhanVien = quanLyNhanVien;
        }

        internal QLNV QuanLyNhanVien { get => quanLyNhanVien; set => quanLyNhanVien = value; }
    
        public void Them(int loai)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nhanVien;

            if (loai == 0)
                nhanVien = ThemKinhNghiem();
            else if (loai == 1)
                nhanVien = ThemTotNghiep();
            else if (loai == 2)
                nhanVien = ThemThucTap();
            else
                throw new ArgumentException("Loại nhân viên không hợp lệ.");

            try
            {
                KiemTraDuLieu(nhanVien);
                quanLyNhanVien.Them(nhanVien);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}, {ex.StackTrace}");
            }
        }

        private KinhNghiem ThemKinhNghiem()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            return new KinhNghiem
            {
                MaNhanVien = MayQuet.DocChuoi("\nNhập mã nhân viên: "),
                HoTen = MayQuet.DocChuoi("Nhập họ tên: "),
                NgaySinh = MayQuet.DocNgay("Nhập ngày/tháng/năm sinh: "),
                SoDienThoai = MayQuet.DocChuoi("Nhập số điện thoại: "),
                Email = MayQuet.DocChuoi("Nhập Email: "),
                SoNamKinhNghiem = MayQuet.DocSoNguyen("Nhập số năm kinh nghiệm: "),
                KyNangChuyenMon = MayQuet.DocChuoi("Nhập kỹ năng chuyên môn: "),
            };
        }

        private TotNghiep ThemTotNghiep()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            return new TotNghiep
            {
                MaNhanVien = MayQuet.DocChuoi("\nNhập mã nhân viên: "),
                HoTen = MayQuet.DocChuoi("Nhập họ tên: "),
                NgaySinh = MayQuet.DocNgay("Nhập ngày/tháng/năm sinh: "),
                SoDienThoai = MayQuet.DocChuoi("Nhập số điện thoại: "),
                Email = MayQuet.DocChuoi("Nhập Email: "),
                NgayTotNghiep = MayQuet.DocNgay("Nhập năm tốt nghiệp: "),
                XepLoaiTotNghiep = MayQuet.DocChuoi("Nhập xếp loại tốt nghiệp: "),
                TenTruongDaiHoc = MayQuet.DocChuoi("Nhập tên trường Đại học: "),      
            };
        }

        private ThucTap ThemThucTap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            return new ThucTap
            {
                MaNhanVien = MayQuet.DocChuoi("\nNhập mã nhân viên: "),
                HoTen = MayQuet.DocChuoi("Nhập họ tên: "),
                NgaySinh = MayQuet.DocNgay("Nhập ngày/tháng/năm sinh: "),
                SoDienThoai = MayQuet.DocChuoi("Nhập số điện thoại: "),
                Email = MayQuet.DocChuoi("Nhập Email: "),
                ChuyenNganh = MayQuet.DocChuoi("Nhập chuyên ngành: "),
                HocKy = MayQuet.DocSoNguyen("Nhập học kỳ: "),
                TenTruongDaiHoc = MayQuet.DocChuoi("Nhập tên trường Đại học: "),
            };
        }

        public void CapNhat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string id = MayQuet.DocChuoi("\nNhập mã nhân viên để cập nhật: ");
            var nhanVien = quanLyNhanVien.TimTheoId(id);
            if (nhanVien == null)
            {
                Console.WriteLine("Nhân viên không tồn tại.");
                return;
            }
            Console.WriteLine("Updating...");
            //update logic
        }

        public void Xoa()
        {
            string id = MayQuet.DocChuoi("\nNhập mã nhân viên để xóa: : ");
            if (quanLyNhanVien.XoaTheoId(id))
            {
                Console.WriteLine("Đã xóa nhân viên thành công.");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại.");
            }
        }

        public void HienThiTatCaNhanVien()
        {
            foreach (var employee in quanLyNhanVien.TimTatCa())
            {
                employee.HienThiThongTin();
            }
        }

        private void KiemTraDuLieu(NhanVien nhanVien)
        {
            XacThuc.KiemTraNgaySinh(nhanVien.NgaySinh);
            XacThuc.KiemTraSoDienThoai(nhanVien.SoDienThoai);
            XacThuc.KiemTraEmail(nhanVien.Email);
            XacThuc.KiemTraHoTen(nhanVien.HoTen);
        }
    }
}
