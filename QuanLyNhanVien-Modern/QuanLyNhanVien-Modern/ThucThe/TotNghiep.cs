using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    internal class TotNghiep : NhanVien
    {
        private DateTime ngayTotNghiep;
        private string xepLoaiTotNghiep;
        private string tenTruongDaiHoc;

        public TotNghiep()
        {
        }

        public TotNghiep(DateTime ngayTotNghiep, string xepLoaiTotNghiep, string tenTruongDaiHoc)
        {
            this.NgayTotNghiep = ngayTotNghiep;
            this.XepLoaiTotNghiep = xepLoaiTotNghiep;
            this.TenTruongDaiHoc = tenTruongDaiHoc;
        }

        public DateTime NgayTotNghiep { get => ngayTotNghiep; set => ngayTotNghiep = value; }
        public string XepLoaiTotNghiep { get => xepLoaiTotNghiep; set => xepLoaiTotNghiep = value; }
        public string TenTruongDaiHoc { get => tenTruongDaiHoc; set => tenTruongDaiHoc = value; }

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
