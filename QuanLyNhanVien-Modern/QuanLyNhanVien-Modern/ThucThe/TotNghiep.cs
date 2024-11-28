using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    public class TotNghiep : NhanVien
    {
        public DateTime NgayTotNghiep { get; set; }
        public string XepLoaiTotNghiep { get; set; }
        public string TenTruongDaiHoc { get; set; }

        public TotNghiep() { }

        public override void HienThiThongTin()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "\n\t\tTốt Nghiệp\n" +
                   "------------------------------------------\n" +
                   $"Mã NV              : {MaNhanVien}\n" +
                   $"Họ Tên             : {HoTen}\n" +
                   $"Ngày Sinh          : {NgaySinh:dd/MM/yyyy}\n" +
                   $"Số Điện Thoại      : {SoDienThoai}\n" +
                   $"Email              : {Email}\n" +
                   $"Ngày Tốt Nghiệp    : {NgayTotNghiep:dd/MM/yyyy}\n" +
                   $"Xếp Loại Tốt Nghiệp: {XepLoaiTotNghiep}\n" +
                   $"Tên Trường Đại Học : {TenTruongDaiHoc}\n" +
                   "------------------------------------------";
        }
    }
}
