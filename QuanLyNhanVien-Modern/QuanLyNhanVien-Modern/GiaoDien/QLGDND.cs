using QuanLyNhanVien_Modern.DichVu;
using QuanLyNhanVien_Modern.ThucThe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.GiaoDien
{
    public class QLGDND
    {
        public QLNV QuanLyNhanVien { get; set; } = new QLNV();

        public QLGDND() { }
    
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
                QuanLyNhanVien.Them(nhanVien);
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
            var nhanVien = QuanLyNhanVien.TimTheoId(id);

            if (nhanVien == null)
            {
                Console.WriteLine("Nhân viên không tồn tại.");
                return;
            }

            Console.WriteLine("Đang cập nhật thông tin...");
            Console.WriteLine("1. Họ tên");
            Console.WriteLine("2. Ngày sinh");
            Console.WriteLine("3. Số điện thoại");
            Console.WriteLine("4. Email");

            if (nhanVien is KinhNghiem)
            {
                Console.WriteLine("5. Số năm kinh nghiệm");
                Console.WriteLine("6. Kỹ năng chuyên môn");
            }
            else if (nhanVien is TotNghiep)
            {
                Console.WriteLine("5. Ngày tốt nghiệp");
                Console.WriteLine("6. Xếp loại tốt nghiệp");
                Console.WriteLine("7. Tên trường đại học");
            }
            else if (nhanVien is ThucTap)
            {
                Console.WriteLine("5. Chuyên ngành");
                Console.WriteLine("6. Học kỳ");
                Console.WriteLine("7. Tên trường đại học");
            }

            int luaChon = MayQuet.DocSoNguyen("\nChọn mục bạn muốn cập nhật: ");

            switch (luaChon)
            {
                case 1:
                    nhanVien.HoTen = MayQuet.DocChuoi("Nhập họ tên mới: ");
                    break;
                case 2:
                    nhanVien.NgaySinh = MayQuet.DocNgay("Nhập ngày sinh mới (dd/MM/yyyy): ");
                    break;
                case 3:
                    nhanVien.SoDienThoai = MayQuet.DocChuoi("Nhập số điện thoại mới: ");
                    break;
                case 4:
                    nhanVien.Email = MayQuet.DocChuoi("Nhập email mới: ");
                    break;
                case 5:
                    if (nhanVien is KinhNghiem kinhNghiem)
                    {
                        kinhNghiem.SoNamKinhNghiem = MayQuet.DocSoNguyen("Nhập số năm kinh nghiệm mới: ");
                    }
                    else if (nhanVien is TotNghiep moiTotNghiep)
                    {
                        moiTotNghiep.NgayTotNghiep = MayQuet.DocNgay("Nhập ngày tốt nghiệp mới (dd/MM/yyyy): ");
                    }
                    else if (nhanVien is ThucTap thucTap)
                    {
                        thucTap.ChuyenNganh = MayQuet.DocChuoi("Nhập chuyên ngành mới: ");
                    }
                    break;
                case 6:
                    if (nhanVien is KinhNghiem kinhNghiem2)
                    {
                        kinhNghiem2.KyNangChuyenMon = MayQuet.DocChuoi("Nhập kỹ năng chuyên môn mới: ");
                    }
                    else if (nhanVien is TotNghiep moiTotNghiep2)
                    {
                        moiTotNghiep2.XepLoaiTotNghiep = MayQuet.DocChuoi("Nhập xếp loại tốt nghiệp mới: ");
                    }
                    else if (nhanVien is ThucTap thucTap2)
                    {
                        thucTap2.HocKy = MayQuet.DocSoNguyen("Nhập học kỳ mới: ");
                    }
                    break;
                case 7:
                    if (nhanVien is TotNghiep moiTotNghiep3)
                    {
                        moiTotNghiep3.TenTruongDaiHoc = MayQuet.DocChuoi("Nhập tên trường đại học mới: ");
                    }
                    else if (nhanVien is ThucTap thucTap3)
                    {
                        thucTap3.TenTruongDaiHoc = MayQuet.DocChuoi("Nhập tên trường đại học mới: ");
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            Console.WriteLine("Cập nhật thành công!");
        }

        public void Xoa()
        {
            string id = MayQuet.DocChuoi("\nNhập mã nhân viên để xóa: : ");
            if (QuanLyNhanVien.XoaTheoId(id))
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
            foreach (var employee in QuanLyNhanVien.TimTatCa())
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
