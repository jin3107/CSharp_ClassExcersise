using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_118
{
    public class QuanLyXetTuyen
    {
        public List<HocVien> danhSachHocVien { get; set; } = new List<HocVien>();

        public QuanLyXetTuyen() { }

        public QuanLyXetTuyen(List<HocVien> danhSachHocVien)
        {
            this.danhSachHocVien = danhSachHocVien;
        }

        public void ThemHocVien()
        {
            try
            {
                HocVien hocVien = new HocVien();
                hocVien.Nhap();
                danhSachHocVien.Add(hocVien);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm học viên: {ex.Message}");
            }
        }

        public void HienThiHocVien()
        {
            try
            {
                int hocVienThu = 0;
                Console.WriteLine("\n --- Danh sách các Học viên ---");
                if (danhSachHocVien.Count() > 0)
                {
                    foreach (var hocVien in danhSachHocVien)
                    {
                        Console.WriteLine($"\n-- Học viên thứ {hocVienThu + 1} --");
                        hocVien.Xuat();
                        hocVienThu++;
                    }
                }
                else
                    Console.WriteLine("Không có học viên trong danh sách");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị học viên: {ex.Message}");
            }
        }

        public void SuaHocVien(string hoTen)
        {
            try
            {
                var hocVien = danhSachHocVien.FirstOrDefault(hv => hv.hoTen == hoTen);
                if (hocVien == null)
                {
                    Console.WriteLine("Không tìm thấy học viên cần sửa");
                    return;
                }
                hocVien.Nhap();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi sửa học viên: {ex.Message}");
            }
        }

        public void XoaHocVien(string hoTen)
        {
            try
            {
                var hocVien = danhSachHocVien.FirstOrDefault(hv => hv.hoTen == hoTen);
                if (hocVien == null)
                {
                    Console.WriteLine("Không tìm thấy học viên cần xóa");
                    return;
                }
                danhSachHocVien.Remove(hocVien);
                Console.WriteLine("Xóa học viên thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa học viên: {ex.Message}");
            }
        }

        public void TimKiemHocVien(string hoTen)
        {
            try
            {
                foreach (var hocVien in danhSachHocVien)
                {
                    var timKiemHocVien = danhSachHocVien.FirstOrDefault(hv => hv.hoTen == hoTen);
                    if (timKiemHocVien == null)
                    {
                        Console.WriteLine("Không tìm thấy học viên");
                        return;
                    }
                    hocVien.Xuat();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm học viên: {ex.Message}");
            }
        }

        public void TrangThaiXetTuyen()
        {
            try
            {
                int LuanVanTotNghiep = 0, TotNghiep = 0, ThiLai = 0;
                foreach (var hocVien in danhSachHocVien)
                {
                    var diemTB = hocVien.diemMonHoc.DiemTB();
                    var diemDuoi5 = hocVien.diemMonHoc.MonDiemDuoi5();
                    if (diemTB > 7 && !diemDuoi5.Any())
                    {
                        LuanVanTotNghiep++;
                    }
                    else if (diemTB <= 7 && !diemDuoi5.Any())
                    {
                        TotNghiep++;
                    }
                    else
                    {
                        ThiLai++;
                        Console.WriteLine($"\nHọc viên {hocVien.hoTen} phải thi lại môn: " + string.Join(", ", diemDuoi5));
                    }
                }
                Console.WriteLine($"\nSố học viên được làm luận văn tốt nghiệp: {LuanVanTotNghiep}");
                Console.WriteLine($"Số học viên thi tốt nghiệp: {TotNghiep}");
                Console.WriteLine($"Số học viên phải thi lại: {ThiLai}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xem trạng thái xét tuyển: {ex.Message}");
            }
        }
    }
}
