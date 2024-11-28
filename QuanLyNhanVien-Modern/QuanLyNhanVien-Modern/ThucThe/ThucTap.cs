using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    public class ThucTap : NhanVien
    {
        public string ChuyenNganh { get; set; }
        public int HocKy { get; set; }
        public string TenTruongDaiHoc { get; set; }

        public ThucTap() { }
        public override void HienThiThongTin()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "\n\t\tThực Tập\n" +
                   "------------------------------------------\n" +
                   $"Mã NV             : {MaNhanVien}\n" +
                   $"Họ Tên            : {HoTen}\n" +
                   $"Ngày Sinh         : {NgaySinh:dd/MM/yyyy}\n" +
                   $"Số Điện Thoại     : {SoDienThoai}\n" +
                   $"Email             : {Email}\n" +
                   $"Chuyên Ngành      : {ChuyenNganh}\n" +
                   $"Học Kỳ            : {HocKy}\n" +
                   $"Tên Trường Đại Học: {TenTruongDaiHoc}\n" +
                   "------------------------------------------";
        }
    }
}
