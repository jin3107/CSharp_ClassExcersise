using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.ThucThe
{
    public class ThucTap : NhanVien
    {
        public string ChuyenNganh { get; set; }
        public int HocKy { get; set; }
        public string TruongDaiHoc { get; set; }

        public ThucTap() { }

        public ThucTap(string maNhanVien, string hoTen, DateTime ngaySinh, string soDienThoai, string email, List<BangCap> danhSachChungChi, 
            string chuyenNganh, int hocKy, string truongDaiHoc) : base(maNhanVien, hoTen, ngaySinh, soDienThoai, email, danhSachChungChi)
        {
            ChuyenNganh = chuyenNganh;
            HocKy = hocKy;
            TruongDaiHoc = truongDaiHoc;
        }

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
                   $"Trường Đại Học: {TruongDaiHoc}\n" +
                   "------------------------------------------";
        }
    }
}
