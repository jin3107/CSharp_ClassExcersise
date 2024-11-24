using QuanLyNhanVien_Modern.NgoaiLe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.DichVu
{
    internal class XacThuc
    {
        public static void KiemTraNgaySinh(DateTime ngaySinh)
        {
            if (ngaySinh > DateTime.Now)
            {
                throw new ArgumentException("Ngày sinh không thể ở tương lai.");
            }
        }

        public static void KiemTraSoDienThoai(string soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(soDienThoai) || !soDienThoai.All(char.IsDigit))
            {
                throw new NgoaiLeSoDienThoai("Số điện thoại không hợp lệ.");
            }
        }

        public static void KiemTraEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new NgoaiLeEmail("Định dạng email không hợp lệ.");
            }
        }

        public static void KiemTraHoTen(string hoTen)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                throw new NgoaiLeHoTen("Tên đầy đủ không thể để trống.");
            }
        }

    }
}
