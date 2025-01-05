using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.ThucThe
{
    public class KinhNghiem : NhanVien
    {
        public int SoNamKinhNghiem { get; set; }
        public string KyNangChuyenMon { get; set; }

        public KinhNghiem()
        {
        }

        public KinhNghiem(string maNhanVien, string hoTen, DateTime ngaySinh, string soDienThoai, string email, List<BangCap> danhSachChungChi, 
            int soNamKinhNghiem, string kyNangChuyenMon) : base(maNhanVien, hoTen, ngaySinh, soDienThoai, email, danhSachChungChi)
        {
            SoNamKinhNghiem = soNamKinhNghiem;
            KyNangChuyenMon = kyNangChuyenMon;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "\n\t\tKinh Nghiệm\n" +
                   "------------------------------------------\n" +
                   $"Mã NV             : {MaNhanVien}\n" +
                   $"Họ Tên            : {HoTen}\n" +
                   $"Ngày Sinh         : {NgaySinh:dd/MM/yyyy}\n" +
                   $"Số Điện Thoại     : {SoDienThoai}\n" +
                   $"Email             : {Email}\n" +
                   $"Số Năm KN         : {SoNamKinhNghiem}\n" +
                   $"Kỹ Năng Chuyên Môn: {KyNangChuyenMon}\n" +
                   "------------------------------------------";
        }
    }
}
