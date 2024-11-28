using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    public abstract class NhanVien
    {
        public static long SoLuong = 0;
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public List<ChungChi> DanhSachChungChi { get; set; } = new List<ChungChi>();

        protected NhanVien() { }

        public abstract void HienThiThongTin();
    }
}
