using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.ThucThe
{
    public abstract class NhanVien
    {
        public static long SoLuong = 0;
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public List<BangCap> DanhSachChungChi { get; set; } = new List<BangCap>();

        protected NhanVien() { }

        protected NhanVien(string maNhanVien, string hoTen, DateTime ngaySinh, string soDienThoai, string email, List<BangCap> danhSachChungChi)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            Email = email;
            DanhSachChungChi = danhSachChungChi;
        }

        public abstract void HienThiThongTin();
    }
}
