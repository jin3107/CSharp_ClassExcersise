using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    internal class ThucTap : NhanVien
    {
        private string chuyenNganh;
        private int hocKy;
        private string tenTruongDaiHoc;

        public ThucTap()
        {
        }

        public ThucTap(string chuyenNganh, int hocKy, string tenTruongDaiHoc)
        {
            this.ChuyenNganh = chuyenNganh;
            this.HocKy = hocKy;
            this.TenTruongDaiHoc = tenTruongDaiHoc;
        }

        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int HocKy { get => hocKy; set => hocKy = value; }
        public string TenTruongDaiHoc { get => tenTruongDaiHoc; set => tenTruongDaiHoc = value; }

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
