using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class KhachSan
    {
        public List<Nguoi> DanhSachNguoi { get; set; } = new List<Nguoi>();
        public KhachSan() { }
    
        public void Them(Nguoi nguoi)
        {
            DanhSachNguoi.Add(nguoi);
        }

        public void Xoa(string cmnd)
        {
            DanhSachNguoi.RemoveAll(n => n.Cmnd == cmnd);
        }

        public int TinhTien(string cmnd)
        {
            var nguoi = DanhSachNguoi.Find(n => n.Cmnd == cmnd);
            if (nguoi != null)
            {
                return nguoi.PhongThue.GiaPhong * nguoi.SoNgayThue;
            }
            return 0;
        }

        public void HienThi()
        {
            foreach (var nguoi in DanhSachNguoi)
            {
                Console.WriteLine(nguoi);
            }
        }
    }
}
