using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    internal abstract class NhanVien
    {
        private static long soLuong = 0;
        private string maNhanVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string soDienThoai;
        private string email;
        private List<ChungChi> danhSachChungChi;

        protected NhanVien()
        {
        }

        public static long SoLuong { get => soLuong; set => soLuong = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        internal List<ChungChi> DanhSachChungChi { get => danhSachChungChi; set => danhSachChungChi = value; }

        public abstract void HienThiThongTin();
    }
}
