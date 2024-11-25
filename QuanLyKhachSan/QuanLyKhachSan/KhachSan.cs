using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    internal class KhachSan
    {
        private List<Nguoi> danhSachNguoi;

        public KhachSan()
        {
            danhSachNguoi = new List<Nguoi>();
        }

        public KhachSan(List<Nguoi> danhSachNguoi)
        {
            this.DanhSachNguoi = danhSachNguoi;
        }

        internal List<Nguoi> DanhSachNguoi { get => danhSachNguoi; set => danhSachNguoi = value; }
    
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
