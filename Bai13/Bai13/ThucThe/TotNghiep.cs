using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.ThucThe
{
    public class TotNghiep : NhanVien
    {
        public DateTime NgayTotNghiep { get; set; }
        public string XepLoai { get; set; }
        public string TruongDaiHoc { get; set; }

        public TotNghiep()
        {
        }

        public TotNghiep(string maNhanVien, string hoTen, DateTime ngaySinh, string soDienThoai, string email, List<BangCap> danhSachChungChi, 
            DateTime ngayTotNghiep, string xepLoai, string truongDaiHoc) : base(maNhanVien, hoTen, ngaySinh, soDienThoai, email, danhSachChungChi)
        {
            NgayTotNghiep = ngayTotNghiep;
            XepLoai = xepLoai;
            TruongDaiHoc = truongDaiHoc;
        }

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
                   $"Xếp Loại Tốt Nghiệp: {XepLoai}\n" +
                   $"Tên Trường Đại Học : {TruongDaiHoc}\n" +
                   "------------------------------------------";
        }
    }
}
