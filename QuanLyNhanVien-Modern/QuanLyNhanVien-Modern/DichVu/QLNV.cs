using QuanLyNhanVien_Modern.ThucThe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.DichVu
{
    public class QLNV
    {
        public List<NhanVien> DanhSachNhanVien { get; set; }

        public QLNV() { }

        public void Them(NhanVien nhanVien)
        {
            DanhSachNhanVien.Add(nhanVien);
        }

        public NhanVien TimTheoId(string id)
        {
            var ketQua = DanhSachNhanVien.FirstOrDefault(x => x.MaNhanVien == id);
            return ketQua;
        }

        public bool XoaTheoId(string id)
        {
            var nhanVien = TimTheoId(id);
            if (nhanVien == null) return false;
            DanhSachNhanVien.Remove(nhanVien);
            return true;
        }

        public List<NhanVien> TimTheoLoai(Type loai)
        {
            return DanhSachNhanVien.Where(nhanVien => nhanVien.GetType() == loai).ToList();
        }

        public List<NhanVien> TimTatCa()
        {
            return DanhSachNhanVien;
        }

    }
}
