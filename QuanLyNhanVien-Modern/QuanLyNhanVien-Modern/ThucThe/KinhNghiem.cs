using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    public class KinhNghiem : NhanVien
    {
        public int SoNamKinhNghiem { get; set; }
        public string KyNangChuyenMon { get; set; }

        public KinhNghiem() { }

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