using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    internal class KinhNghiem : NhanVien
    {
        private int soNamKinhNghiem;
        private string kyNangChuyenMon;

        public KinhNghiem()
        {
        }

        public KinhNghiem(int soNamKinhNghiem, string kyNangChuyenMon)
        {
            this.SoNamKinhNghiem = soNamKinhNghiem;
            this.KyNangChuyenMon = kyNangChuyenMon;
        }

        public int SoNamKinhNghiem { get => soNamKinhNghiem; set => soNamKinhNghiem = value; }
        public string KyNangChuyenMon { get => kyNangChuyenMon; set => kyNangChuyenMon = value; }

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